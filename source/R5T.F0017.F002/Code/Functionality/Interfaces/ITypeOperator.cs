using System;
using System.Collections.Generic;
using System.Linq;

using R5T.T0132;


namespace R5T.F0017.F002
{
    [DraftFunctionalityMarker]
    public interface ITypeOperator : IDraftFunctionalityMarker
    {
        public Dictionary<string, string> GetMethodTypeParameterMangledNamesByName(IEnumerable<Type> methodTypeParameters)
        {
            var counter = 0;

            var methodTypeParameterMangledNamesByName = methodTypeParameters
                .ToDictionary(
                    x => x.Name,
                    // .NET uses a double-tick for method type parameters.
                    x => $"``{counter++}");

            return methodTypeParameterMangledNamesByName;
        }

        public Dictionary<string, string> GetTypeTypeParameterMangledNamesByName(IEnumerable<Type> typeTypeParameters)
        {
            var counter = 0;

            var typeTypeParameterMangledNamesByName = typeTypeParameters
                .ToDictionary(
                    x => x.Name,
                    // .NET uses a single-tick for type type parameters.
                    x => $"`{counter++}");

            return typeTypeParameterMangledNamesByName;
        }

        /// <summary>
        /// A type is a class, interface, struct, enum, or delegate.
        /// </summary>
        public bool IsType(Type type)
        {
            var output = type.IsTypeDefinition;
            return output;
        }
    }
}
