using System;

using R5T.T0131;


namespace R5T.F0017.F002.V000
{
    [ValuesMarker]
    public partial interface IParameterNamedIdentityNames : IValuesMarker
    {
        private static Z000.IParameterNamedIdentityNames RawParameterNamedIdentityNames => Z000.ParameterNamedIdentityNames.Instance;

        /// <inheritdoc cref="T0140.ExampleClass01{T}" path="/description"/>
        public string Class_OpenGeneric => RawParameterNamedIdentityNames.ExampleClass01;

        /// <inheritdoc cref="T0140.ExampleMethods.Method13(System.Collections.Generic.Dictionary{string, System.Collections.Generic.List{T0140.ExampleClass00}}, string)"/>
        public string Method_WithNestedClosedGenericArgument => RawParameterNamedIdentityNames.Method14;
    }
}
