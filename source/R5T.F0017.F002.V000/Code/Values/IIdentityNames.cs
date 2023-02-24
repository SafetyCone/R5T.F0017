using System;

using R5T.T0131;


namespace R5T.F0017.F002.V000
{
    [ValuesMarker]
    public partial interface IIdentityNames : IValuesMarker
    {
        private static Z000.IIdentityNames RawIdentityNames => Z000.IdentityNames.Instance;


        public string Class_Basic => RawIdentityNames.ExampleClass00;
        public string Class_OpenGeneric => RawIdentityNames.ExampleClass01;

        public string Property_Basic => RawIdentityNames.Property01;
        public string Property_OnGenericClass => RawIdentityNames.Property20;

        public string Method_Basic => RawIdentityNames.Method01;
        public string Method_WithNestedClosedGenericArgument => RawIdentityNames.Method13;

        public string Method_GenericMethodOnGenericClass => RawIdentityNames.Method104;
        public string Method_GenericMethodOnGenericClass_WithBothGenericTypesAsArguments => RawIdentityNames.Method105;
        public string Method_GenericMethodOnGenericClass_WithBothGenericTypesAndStringAsArguments => RawIdentityNames.Method106;
        public string Method_NestedGenericTypeAsArgument => RawIdentityNames.Method107;
    }
}
