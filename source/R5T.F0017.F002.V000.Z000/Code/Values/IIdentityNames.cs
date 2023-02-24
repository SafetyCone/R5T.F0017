using System;

using R5T.T0131;


namespace R5T.F0017.F002.V000.Z000
{
    /// <summary>
    /// Provides identity names for code elements from the R5T.T0140 library.
    /// </summary>
    [ValuesMarker]
    public interface IIdentityNames : IValuesMarker
    {
        public string ExampleClass00 => "T:R5T.T0140.ExampleClass00";
        public string ExampleClass01 => "T:R5T.T0140.ExampleClass01`1";

        public string Method01 => "M:R5T.T0140.ExampleMethods.Method01";
        public string Method02 => "M:R5T.T0140.ExampleMethods.Method02";
        public string Method03 => "M:R5T.T0140.ExampleMethods.Method03``1";
        public string Method13 => "M:R5T.T0140.ExampleMethods.Method13(System.Collections.Generic.Dictionary{System.String,System.Collections.Generic.List{R5T.T0140.ExampleClass00}},System.String)";

        public string Method103 => "M:R5T.T0140.ExampleMethods`1.Method103(`0)";
        public string Method104 => "M:R5T.T0140.ExampleMethods`1.Method104``1";
        public string Method105 => "M:R5T.T0140.ExampleMethods`1.Method105``1(`0,``0)";
        public string Method106 => "M:R5T.T0140.ExampleMethods`1.Method106``1(`0,``0,System.String)";
        public string Method107 => "M:R5T.T0140.ExampleMethods`1.Method107``1(System.Func{System.Collections.Generic.Dictionary{`0,System.Collections.Generic.IEnumerable{``0}}})";

        public string Property01 => "P:R5T.T0140.ExampleProperties.Property01";
        public string Property20 => "P:R5T.T0140.ExampleProperties`1.Property20";
    }
}
