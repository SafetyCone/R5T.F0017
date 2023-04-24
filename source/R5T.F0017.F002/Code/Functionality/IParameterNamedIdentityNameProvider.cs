using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

using R5T.T0132;


namespace R5T.F0017.F002
{
    [FunctionalityMarker]
    public partial interface IParameterNamedIdentityNameProvider : IFunctionalityMarker
    {
        public string GetNamespacedTypeName(Type type)
        {
            var isGeneric = type.IsGenericType;

            var typeName = isGeneric
                ? type.Name[..type.Name.IndexOf(
                    Instances.Characters.Tick)]
                : type.Name
                ;

            var output = $"{type.Namespace}.{typeName}";
            return output;
        }

        public string GetTypeParametersToken(IEnumerable<Type> typeParameters)
        {
            var anyTypeParameters = typeParameters.Any();

            var output = anyTypeParameters
                ? "<" + String.Join(", ", typeParameters
                    .Select(xMethodTypeParameter => xMethodTypeParameter.Name)) + ">"
                : String.Empty
                ;

            return output;
        }

        public string GetParameterNamedIdentityName(Type typeInfo)
        {
            var parameterNamedIdentityNameValue = this.GetParameterNamedIdentityNameValue(typeInfo);

            var output = $"T:{parameterNamedIdentityNameValue}";
            return output;
        }

        public string GetParameterNamedIdentityName(PropertyInfo propertyInfo)
        {
            var identityName = Instances.IdentityNameProvider.GetIdentityName(propertyInfo);

            // Append the type of the property.
            var returnTypeToken = this.GetParameterTypeNameForMethodIdentityName(propertyInfo.PropertyType);

            var output = $"{identityName};{returnTypeToken}";
            return output;
        }

        public string GetParameterNamedIdentityName(MethodInfo methodInfo)
        {
            var declaringTypeParameterNamedIdentityNameValue = this.GetParameterNamedIdentityNameValue(methodInfo.DeclaringType);

            var methodNameToken = methodInfo.Name;

            var methodTypeParameters = methodInfo.GetGenericArguments();

            var methodTypeParametersToken = this.GetTypeParametersToken(methodTypeParameters);

            // TODO: any restrictions on type parameters?

            var parameters = methodInfo.GetParameters();

            var parametersToken = parameters.Any()
                ? "(" + String.Join(", ", parameters
                        .Select(xParameter => this.GetParameterTokenForMethodIdentityName(xParameter))) + ")"
                : Instances.Strings.PairedParentheses;
            ;

            // Return (output) token.
            var returnTypeToken = this.GetParameterTypeNameForMethodIdentityName(methodInfo.ReturnType);

            var output = $"M:{declaringTypeParameterNamedIdentityNameValue}.{methodNameToken}{methodTypeParametersToken}{parametersToken};{returnTypeToken}";
            return output;
        }

        public string GetParameterNamedIdentityNameValue(Type type)
        {
            var typeTypeParameters = type.GetGenericArguments();

            var typeTypeParametersToken = this.GetTypeParametersToken(typeTypeParameters);

            var namespacedTypeName = this.GetNamespacedTypeName(type);

            var output = $"{namespacedTypeName}{typeTypeParametersToken}";
            return output;
        }

        public string GetParameterTokenForMethodIdentityName(ParameterInfo parameter)
        {
            var parameterTypeName = this.GetParameterTypeNameForMethodIdentityName(parameter.ParameterType);

            var output = $"{parameterTypeName} {parameter.Name}";
            return output;
        }

        public string GetParameterTypeNameForMethodIdentityName(Type parameterType)
        {
            if (parameterType.IsGenericType)
            {
                // Keep only the portion up to the generic type parameter arity token separator.
                var adjustedName = parameterType.Name.Split('`').First();

                var namespacedTypeName = $"{parameterType.Namespace}.{adjustedName}";

                var genericArguments = parameterType.GetGenericArguments();

                var argumentsToken = String.Join(", ", genericArguments
                    // Recurse.
                    .Select(xGenericArgumentType => this.GetParameterTypeNameForMethodIdentityName(xGenericArgumentType)));

                var output = $"{namespacedTypeName}{{{argumentsToken}}}"
                    .Replace(
                        Instances.Characters.OpenBracket,
                        Instances.Characters.OpenAngleBracket)
                    .Replace(
                        Instances.Characters.CloseBracket,
                        Instances.Characters.CloseAngleBracket)
                    ;
                return output;
            }

            if (parameterType.IsGenericTypeParameter || parameterType.IsGenericMethodParameter)
            {
                return parameterType.Name;
            }

            return parameterType.FullName;
        }
    }
}
