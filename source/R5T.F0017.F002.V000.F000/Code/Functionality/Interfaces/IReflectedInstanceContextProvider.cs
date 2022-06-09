using System;
using System.Linq;
using System.Reflection;

using R5T.T0132;


namespace R5T.F0017.F002.V000.F000
{
    [FunctionalityMarker]
    public interface IReflectedInstanceContextProvider : IFunctionalityMarker
    {
        public TOut InExampleMethodContext<TOut>(
            string typeName,
            string methodName,
            Func<MethodInfo, TOut> methodInfoFunction)
        {
            var output = this.InExampleTypeContext(
                typeName,
                typeInfo =>
                {
                    var methodInfo = typeInfo.DeclaredMethods
                        .Where(xMethod => xMethod.Name == methodName)
                        // Throw if none, use first for speed (avoid evaluating all methods as required by single) since we know there should only be zero or one methods.
                        .First();

                    var output = methodInfoFunction(methodInfo);
                    return output;
                });

            return output;
        }

        public TOut InExamplePropertyContext<TOut>(
            string typeName,
            string propertyName,
            Func<PropertyInfo, TOut> propertyInfoFunction)
        {
            var output = this.InExampleTypeContext(
                typeName,
                typeInfo =>
                {
                    var propertyInfo = typeInfo.DeclaredProperties
                        .Where(xProperty => xProperty.Name == propertyName)
                        // Throw if none, use first for speed (avoid evaluating all methods as required by single) since we know there should only be zero or one methods.
                        .First();

                    var output = propertyInfoFunction(propertyInfo);
                    return output;
                });

            return output;
        }

        public TOut InExampleMethodContext<TOut>(
            Type type,
            string methodName,
            Func<MethodInfo, TOut> methodInfoFunction)
        {
            var typeName = type.FullName;

            return this.InExampleMethodContext(
                typeName,
                methodName,
                methodInfoFunction);
        }

        public TOut InExamplePropertyContext<TOut>(
            Type type,
            string propertyName,
            Func<PropertyInfo, TOut> propertyInfoFunction)
        {
            var typeName = type.FullName;

            return this.InExamplePropertyContext(
                typeName,
                propertyName,
                propertyInfoFunction);
        }

        public TOut InExampleTypeContext<TOut>(
            string typeName,
            Func<TypeInfo, TOut> typeInfoFunction)
        {
            var output = Instances.ReflectionOperator.InAssemblyContext(
                Instances.ExamplesAssemblyFilePathProvider.GetExamplesAssemblyFilePath(),
                assembly =>
                {
                    var typeInfo = assembly.DefinedTypes
                        .Where(xType => xType.FullName == typeName)
                        // Throw if none, use first for speed (avoid evaluating all types as required by single) since we know there should only be zero or one types.
                        .First();

                    var output = typeInfoFunction(typeInfo);
                    return output;
                });

            return output;
        }

        public TOut InExampleTypeContext<TOut>(
            Type type,
            Func<TypeInfo, TOut> typeInfoFunction)
        {
            var typeName = type.FullName;

            return this.InExampleTypeContext(
                typeName,
                typeInfoFunction);
        }

        public TOut InExampleTypeContext<T, TOut>(
            Func<TypeInfo, TOut> typeInfoFunction)
        {
            var type = typeof(T);

            return this.InExampleTypeContext(
                type,
                typeInfoFunction);
        }
    }
}
