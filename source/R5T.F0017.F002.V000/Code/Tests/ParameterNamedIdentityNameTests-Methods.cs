using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using R5T.T0140;


namespace R5T.F0017.F002.V000
{
    public partial class ParameterNamedIdentityNameTests
    {
        /// <summary>
        /// <inheritdoc cref="ExampleMethods.Method13"/>
        /// </summary>
        [TestMethod]
        public void Method_WithNestedClosedGenericArgument()
        {
            var actual = Instances.ReflectedInstanceContextProvider.InExampleMethodContext(
                typeof(ExampleMethods),
                nameof(ExampleMethods.Method13),
                methodInfo => Instances.ParameterNamedIdentityNameProvider.GetParameterNamedIdentityName(methodInfo));

            var expected = Instances.ParameterNamedIdentityNames.Method_WithNestedClosedGenericArgument;

            Instances.Assertion.AreEqual(
                expected,
                actual);
        }
    }
}
