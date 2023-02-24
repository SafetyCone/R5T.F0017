using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using R5T.T0140;


namespace R5T.F0017.F002.V000
{
    public partial class IdentityNameTests
    {
        /// <summary>
        /// <inheritdoc cref="ExampleClass00" path="/description"/>
        /// </summary>
        [TestMethod]
        public void Class_Basic()
        {
            var actual = Instances.TypeOperator.GetTypeIdentityName(
                Instances.ExampleTypes.BasicClass);

            var expected = Instances.IdentityNames.Class_Basic;

            Instances.Assertion.AreEqual(
                expected,
                actual);
        }

        /// <summary>
        /// <inheritdoc cref="ExampleClass01{T}" path="/description"/>
        /// </summary>
        [TestMethod]
        public void Class_OpenGeneric()
        {
            var actual = Instances.TypeOperator.GetTypeIdentityName(
                Instances.ExampleTypes.OpenGenericClass);

            var expected = Instances.IdentityNames.Class_OpenGeneric;

            Instances.Assertion.AreEqual(
                expected,
                actual);
        }
    }
}
