using System;


namespace R5T.F0017.F002.V000
{
    public static class Instances
    {
        public static T0119.IAssertion Assertion { get; } = T0119.Assertion.Instance;
        public static Z000.IIdentityNames IdentityNames { get; } = Z000.IdentityNames.Instance;
        public static IIdentityNameProvider IdentityNameProvider { get; } = F002.IdentityNameProvider.Instance;
        public static F000.IReflectedInstanceContextProvider ReflectedInstanceContextProvider { get; } = F000.ReflectedInstanceContextProvider.Instance;
        public static Functionalities.ITypeOperator TypeOperator { get; } = Functionalities.TypeOperator.Instance;
    }
}