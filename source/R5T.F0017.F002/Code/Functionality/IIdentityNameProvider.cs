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
        public string GetIdentityName(FieldInfo fieldInfo)
        {
            var declaringTypeIdentityNameValue = GetIdentityNameValue(fieldInfo.DeclaringType);

            var fieldNameToken = fieldInfo.Name;

            var output = $"P:{declaringTypeIdentityNameValue}.{fieldNameToken}";
            return output;
        }

        public string GetIdentityName(PropertyInfo propertyInfo)
        {
            var declaringTypeIdentityNameValue = GetIdentityNameValue(propertyInfo.DeclaringType);

            var propertyNameToken = propertyInfo.Name;

            // TODO, handle indexers.
            var isIndexer = propertyInfo.GetIndexParameters().Any();
            if (isIndexer)
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
                : string.Empty
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
                    + string.Join(",", parameters
                        .Select(xParameter => GetParameterTypeNameForMethodIdentityName(
                            xParameter.ParameterType,
                            typeTypeParameterMangledNamesByName,
                            methodTypeParameterMangledNamesByName)))
                    + ")"
                : string.Empty;
            ;

            return output;
        }

        public string GetParameterTypeNameForMethodIdentityName(Type parameterType,
            Dictionary<string, string> typeTypeParameterMangledNamesByName,
            Dictionary<string, string> methodTypeParameterMangledNamesByName)
        {
            if(parameterType.IsArray)
            {
                var elementType = parameterType.GetElementType();

                var elementTypeName = this.GetParameterTypeNameForMethodIdentityName(
                    elementType,
                    typeTypeParameterMangledNamesByName,
                    methodTypeParameterMangledNamesByName);

                var output = elementTypeName + "[]";
                return output;
            }

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

            // parameterType.IsGenericType is WRONG for types like Dictionary`2&, System.Collections.Generic.Dictionary`2[[Microsoft.CodeAnalysis.SyntaxTrivia, Microsoft.CodeAnalysis, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35],[Microsoft.CodeAnalysis.SyntaxAnnotation, Microsoft.CodeAnalysis, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35]]&
            // It says false when it should say true!
            // So use a better for-ref type.
            var genericArguments = parameterType.GetGenericArguments();

            var isGenericType = genericArguments.Any();
            if (isGenericType)
            {
                // Keep only the portion up to the generic type parameter arity token separator.
                var adjustedName = parameterType.Name.Split('`').First();

                var namespacedTypeName = $"{parameterType.Namespace}.{adjustedName}";

                var argumentsToken = string.Join(",", genericArguments
                    // Recurse.
                    .Select(xGenericArgumentType => GetParameterTypeNameForMethodIdentityName(
                        xGenericArgumentType,
                        typeTypeParameterMangledNamesByName,
                        methodTypeParameterMangledNamesByName)));

                var referenceToken = parameterType.IsByRef
                    // Uses the @, not & symbol.
                    ? Instances.Strings.At
                    : Instances.Strings.Empty
                    ;

                var output = $"{namespacedTypeName}{{{argumentsToken}}}{referenceToken}";
                return output;
            }

            return parameterType.FullName;
        }

        public string GetIdentityName(TypeInfo typeInfo)
        {
            var output = GetIdentityName(typeInfo as Type);
            return output;
        }

        public string GetIdentityName(Type type)
        {
            var identityNameValue = GetIdentityNameValue(type);

            var output = $"T:{identityNameValue}";
            return output;
        }

        /// <summary>
        /// The identity name value is the portion of an identity name that follows the type identifier.
        /// In the case of a type, the portion after "T:".
        /// </summary>
        public string GetIdentityNameValue(Type type)
        {
            // If the type is a generic type, process generic type arguments.
            var isGeneric = Instances.TypeOperator.Is_Generic(type);

            var typeIdentityNameValue = isGeneric
                ? GetIdentityNameValue_GenericType(type)
                : GetIdentityNameValue_NonGenericType(type)
                ;

            return typeIdentityNameValue;
        }

        public string GetIdentityNameValue_GenericType(Type type)
        {
            var namespacedTypeName = Instances.TypeOperator.Get_NamespacedTypeName(type);

            var typeIdentityName = namespacedTypeName;
            return typeIdentityName;
        }

        public string GetIdentityNameValue_GenericType_WithTypeParameters(Type type)
        {
            var namespacedTypeName = Instances.TypeOperator.Get_NamespacedTypeName(type);

            // Do not get the values, since the generic type might be open, and if it is closed or partially closed, then the parameters will be the same as the values.
            var genericTypeParameters = Instances.TypeOperator.Get_GenericTypeArguments(type);

            var genericTypeParameterNames = genericTypeParameters
                .Select(xGenericTypeParameter =>
                {
                    var isUnspecified = Instances.TypeOperator.Is_UnspecifiedGenericTypeParameterValue(xGenericTypeParameter);

                    var genericTypeParameterName = isUnspecified
                        ? xGenericTypeParameter.Name
                        : GetIdentityNameValue(xGenericTypeParameter)
                        ;

                    return genericTypeParameterName;
                })
                .Select(genericTypeParameterName => $"[{genericTypeParameterName}]")
                ;

            var typeParameterNamesJoined = F0000.StringOperator.Instance.Join(
                Z0000.Characters.Instance.Comma,
                genericTypeParameterNames);

            var typeParametersNamesText = $"[{typeParameterNamesJoined}]";

            var typeIdentityName = $"{namespacedTypeName}{typeParametersNamesText}";

            return typeIdentityName;
        }

        public string GetIdentityNameValue_NonGenericType(Type type)
        {
            // For non-generic types, the type full name is sufficient to be the type identity name value.
            var typeIdentityNameValue = type.FullName;
            return typeIdentityNameValue;
        }
    }
}
