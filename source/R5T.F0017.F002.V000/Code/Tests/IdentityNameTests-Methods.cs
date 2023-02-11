using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using R5T.T0140;


namespace R5T.F0017.F002.V000
{
    public partial class IdentityNameTests
    {
        /// <summary>
        /// <inheritdoc cref="T0140.ExampleMethods.Method01"/>
        /// </summary>
        [TestMethod]
        public void Method01()
        {
            var actual = Instances.ReflectedInstanceContextProvider.InExampleMethodContext(
                typeof(T0140.ExampleMethods),
                nameof(T0140.ExampleMethods.Method01),
                methodInfo => Instances.IdentityNameProvider.GetIdentityName(methodInfo));

            var expected = Instances.IdentityNames.Method01;

            Instances.Assertion.AreEqual(
                actual,
                expected);
        }

        /// <summary>
        /// <inheritdoc cref="T0140.ExampleMethods{T}.Method103"/>
        /// </summary>
        [TestMethod]
        public void Method103()
        {
            var actual = Instances.ReflectedInstanceContextProvider.InExampleMethodContext(
                typeof(T0140.ExampleMethods<>),
                "Method104",
                methodInfo => Instances.IdentityNameProvider.GetIdentityName(methodInfo));

            var expected = Instances.IdentityNames.Method104;

            Instances.Assertion.AreEqual(
                actual,
                expected);
        }

        /// <summary>
        /// <inheritdoc cref="T0140.ExampleMethods{T}.Method105"/>
        /// </summary>
        [TestMethod]
        public void Method105()
        {
            var actual = Instances.ReflectedInstanceContextProvider.InExampleMethodContext(
                typeof(T0140.ExampleMethods<>),
                "Method105",
                methodInfo => Instances.IdentityNameProvider.GetIdentityName(methodInfo));

            var expected = Instances.IdentityNames.Method105;

            Instances.Assertion.AreEqual(
                actual,
                expected);
        }

        /// <summary>
        /// <inheritdoc cref="T0140.ExampleMethods{T}.Method106"/>
        /// </summary>
        [TestMethod]
        public void Method106()
        {
            var actual = Instances.ReflectedInstanceContextProvider.InExampleMethodContext(
                typeof(T0140.ExampleMethods<>),
                "Method106",
                methodInfo => Instances.IdentityNameProvider.GetIdentityName(methodInfo));

            var expected = Instances.IdentityNames.Method106;

            Instances.Assertion.AreEqual(
                actual,
                expected);
        }

        /// <summary>
        /// <inheritdoc cref="T0140.ExampleMethods{T}.Method107"/>
        /// </summary>
        [TestMethod]
        public void Method107()
        {
            var actual = Instances.ReflectedInstanceContextProvider.InExampleMethodContext(
                typeof(T0140.ExampleMethods<>),
                "Method107",
                methodInfo => Instances.IdentityNameProvider.GetIdentityName(methodInfo));

            var expected = Instances.IdentityNames.Method107;

            Instances.Assertion.AreEqual(
                actual,
                expected);
        }
    }
}
