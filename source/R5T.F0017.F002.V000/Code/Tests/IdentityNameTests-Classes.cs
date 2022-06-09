using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace R5T.F0017.F002.V000
{
    public partial class IdentityNameTests
    {
        /// <summary>
        /// <inheritdoc cref="T000.ExampleClass00" path="/description"/>
        /// </summary>
        [TestMethod]
        public void ExampleClass00()
        {
            var actual = Instances.TypeOperator.GetTypeIdentityName(
                typeof(T000.ExampleClass00));

            var expected = Instances.IdentityNames.ExampleClass00;

            Instances.Assertion.AreEqual(
                actual,
                expected);
        }

        /// <summary>
        /// <inheritdoc cref="T000.ExampleClass01{T}" path="/description"/>
        /// </summary>
        [TestMethod]
        public void ExampleClass01()
        {
            var actual = Instances.TypeOperator.GetTypeIdentityName(
                typeof(T000.ExampleClass01<>));

            var expected = Instances.IdentityNames.ExampleClass01;

            Instances.Assertion.AreEqual(
                actual,
                expected);
        }
    }
}
