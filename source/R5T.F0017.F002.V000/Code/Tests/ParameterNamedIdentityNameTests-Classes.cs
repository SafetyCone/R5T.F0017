using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using R5T.T0140;


namespace R5T.F0017.F002.V000
{
    public partial class ParameterNamedIdentityNameTests
    {
        /// <summary>
        /// <inheritdoc cref="ExampleClass01{T}" path="/description"/>
        /// </summary>
        [TestMethod]
        public void Class_OpenGeneric()
        {
            var actual = Instances.ParameterNamedIdentityNameProvider.GetParameterNamedIdentityName(
                Instances.ExampleTypes.OpenGenericClass);

            var expected = Instances.ParameterNamedIdentityNames.Class_OpenGeneric;

            Instances.Assertion.AreEqual(
                expected,
                actual);
        }
    }
}
