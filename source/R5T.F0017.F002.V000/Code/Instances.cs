using System;


namespace R5T.F0017.F002.V000
{
    public static class Instances
    {
        public static F0101.IAssertion Assertion => F0101.Assertion.Instance;
        public static T0140.Z001.IExampleTypes ExampleTypes => T0140.Z001.ExampleTypes.Instance;
        public static IIdentityNames IdentityNames => V000.IdentityNames.Instance;
        public static IIdentityNameProvider IdentityNameProvider => F002.IdentityNameProvider.Instance;
        public static IParameterNamedIdentityNameProvider ParameterNamedIdentityNameProvider => F002.ParameterNamedIdentityNameProvider.Instance;
        public static IParameterNamedIdentityNames ParameterNamedIdentityNames => V000.ParameterNamedIdentityNames.Instance;
        public static F000.IReflectedInstanceContextProvider ReflectedInstanceContextProvider => F000.ReflectedInstanceContextProvider.Instance;
        public static Functionalities.ITypeOperator TypeOperator => Functionalities.TypeOperator.Instance;
    }
}