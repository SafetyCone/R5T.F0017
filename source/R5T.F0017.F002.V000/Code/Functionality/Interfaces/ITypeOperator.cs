using System;

using R5T.T0132;


namespace R5T.F0017.F002.V000
{
    [FunctionalityMarker]
    public interface ITypeOperator : IFunctionalityMarker
    {
        public string GetTypeIdentityName(Type type)
        {
            var output = Instances.ReflectedInstanceContextProvider.InExampleTypeContext(
                type,
                typeInfo =>
                {
                    var output = Instances.IdentityNameProvider.GetIdentityName(typeInfo);
                    return output;
                });

            return output;
        }
    }
}
