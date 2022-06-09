using System;


namespace R5T.F0017.F002
{
    public static class Instances
    {
        public static IIdentityNameProvider IdentityNameProvider { get; } = F002.IdentityNameProvider.Instance;
        public static ITypeOperator TypeOperator { get; } = F002.TypeOperator.Instance;
    }
}