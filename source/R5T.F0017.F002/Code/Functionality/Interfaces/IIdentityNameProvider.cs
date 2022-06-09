using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

using R5T.T0132;


namespace R5T.F0017.F002
{
    [DraftFunctionalityMarker]
    public interface IIdentityNameProvider : IDraftFunctionalityMarker
    {
        public string GetIdentityName(PropertyInfo propertyInfo)
        {
            var declaringTypeIdentityNameValue = this.GetIdentityNameValue(propertyInfo.DeclaringType);

            var propertyNameToken = propertyInfo.Name;

            // TODO, handle indexers.
            var isIndexer = propertyInfo.GetIndexParameters().Any();
            if(isIndexer)
            {
                throw new NotImplementedException("Indexers are unhandled.");
            }

            var output = $"P:{declaringTypeIdentityNameValue}.{propertyNameToken}";
            return output;
        }

        public string GetIdentityName(MethodInfo methodInfo)
        {
            var declaringTypeIdentityNameValue = this.GetIdentityNameValue(methodInfo.DeclaringType);

            var methodNameToken = methodInfo.Name;

            var methodTypeParameterArityToken = this.GetMethodTypeParametersArityToken(methodInfo);

            var parametersToken = this.GetMethodParametersToken(methodInfo);

            var output = $"M:{declaringTypeIdentityNameValue}.{methodNameToken}{methodTypeParameterArityToken}{parametersToken}";
            return output;
        }

        public string GetMethodTypeParametersArityToken(MethodInfo methodInfo)
        {
            var methodTypeParameters = methodInfo.GetGenericArguments();

            var methodTypeParameterArity = methodTypeParameters.Length;

            var output = methodInfo.IsGenericMethod
                ? $"``{methodTypeParameterArity}"
                : String.Empty
                ;

            return output;
        }

        public string GetMethodParametersToken(MethodInfo methodInfo)
        {
            var typeTypeParameters = methodInfo.DeclaringType.GetGenericArguments();

            var typeTypeParameterMangledNamesByName = Instances.TypeOperator.GetTypeTypeParameterMangledNamesByName(typeTypeParameters);

            var methodTypeParameters = methodInfo.GetGenericArguments();

            var methodTypeParameterMangledNamesByName = Instances.TypeOperator.GetMethodTypeParameterMangledNamesByName(methodTypeParameters);

            var parameters = methodInfo.GetParameters();

            var output = parameters.Any()
                ? "("
                    + String.Join(",", parameters
                        .Select(xParameter => this.GetParameterTypeNameForMethodIdentityName(
                            xParameter.ParameterType,
                            typeTypeParameterMangledNamesByName,
                            methodTypeParameterMangledNamesByName)))
                    + ")"
                : String.Empty;
            ;

            return output;
        }

        public string GetParameterTypeNameForMethodIdentityName(Type parameterType,
            Dictionary<string, string> typeTypeParameterMangledNamesByName,
            Dictionary<string, string> methodTypeParameterMangledNamesByName)
        {
            if (parameterType.IsGenericMethodParameter)
            {
                var output = methodTypeParameterMangledNamesByName[parameterType.Name];
                return output;
            }

            if (parameterType.IsGenericTypeParameter)
            {
                var output = typeTypeParameterMangledNamesByName[parameterType.Name];
                return output;
            }

            if(parameterType.IsGenericType)
            {
                // Keep only the portion up to the generic type parameter arity token separator.
                var adjustedName = parameterType.Name.Split('`').First();

                var namespacedTypeName = $"{parameterType.Namespace}.{adjustedName}";

                var genericArguments = parameterType.GetGenericArguments();

                var argumentsToken = String.Join(",", genericArguments
                    // Recurse.
                    .Select(xGenericArgumentType => this.GetParameterTypeNameForMethodIdentityName(
                        xGenericArgumentType,
                        typeTypeParameterMangledNamesByName,
                        methodTypeParameterMangledNamesByName)));

                var output = $"{namespacedTypeName}{{{argumentsToken}}}";
                return output;
            }

            return parameterType.FullName;
        }

        public string GetIdentityName(TypeInfo typeInfo)
        {
            var output = this.GetIdentityName(typeInfo as Type);
            return output;
        }

        public string GetIdentityName(Type type)
        {
            var identityNameValue = this.GetIdentityNameValue(type);

            var output = $"T:{identityNameValue}";
            return output;
        }

        /// <summary>
        /// The identity name value is the portion of an identity name that follows the type identifier.
        /// In the case of a type, the portion after "T:".
        /// </summary>
        public string GetIdentityNameValue(Type type)
        {
            var isType = Instances.TypeOperator.IsType(type);
            if (!isType)
            {
                throw new Exception("IdentityName for type not implemented.");
            }

            var output = type.FullName;
            return output;
        }
    }
}
