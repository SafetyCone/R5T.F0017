using System;


namespace R5T.F0017.Construction
{
    public static class Instances
    {
        public static F002.V000.Z000.IIdentityNames IdentityNames { get; } = F002.V000.Z000.IdentityNames.Instance;
        public static F002.IIdentityNameProvider IdentityNameProvider { get; } = F002.IdentityNameProvider.Instance;
        public static IOperations Operations { get; } = Construction.Operations.Instance;
        public static F002.V000.F000.IReflectedInstanceContextProvider ReflectedInstanceContextProvider { get; } = F002.V000.F000.ReflectedInstanceContextProvider.Instance;
    }
}