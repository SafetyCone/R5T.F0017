using System;


namespace R5T.F0017.F002
{
    public static class Instances
    {
        public static Z0000.ICharacters Characters => Z0000.Characters.Instance;
        public static IIdentityNameProvider IdentityNameProvider => F002.IdentityNameProvider.Instance;
        public static F0000.INamespacedTypeNameOperator NamespacedTypeNameOperator => F0000.NamespacedTypeNameOperator.Instance;
        public static Z0000.IStrings Strings => Z0000.Strings.Instance;
        public static L0053.ITokenSeparators TokenSeparators => L0053.TokenSeparators.Instance;
        public static ITypeOperator TypeOperator => F002.TypeOperator.Instance;
    }
}