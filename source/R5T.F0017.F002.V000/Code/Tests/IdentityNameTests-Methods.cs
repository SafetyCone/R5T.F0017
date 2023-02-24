using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using R5T.T0140;


namespace R5T.F0017.F002.V000
{
    public partial class IdentityNameTests
    {
        /// <summary>
        /// <inheritdoc cref="ExampleMethods.Method01"/>
        /// </summary>
        [TestMethod]
        public void Method_Basic()
        {
            var actual = Instances.ReflectedInstanceContextProvider.InExampleMethodContext(
                typeof(ExampleMethods),
                nameof(ExampleMethods.Method01),
                methodInfo => Instances.IdentityNameProvider.GetIdentityName(methodInfo));

            var expected = Instances.IdentityNames.Method_Basic;

            Instances.Assertion.AreEqual(
                expected,
                actual);
        }

        /// <summary>
        /// <inheritdoc cref="ExampleMethods.Method13"/>
        /// </summary>
        [TestMethod]
        public void Method_NestedClosedGenericTypeAsArgument()
        {
            var actual = Instances.ReflectedInstanceContextProvider.InExampleMethodContext(
                typeof(ExampleMethods),
                nameof(ExampleMethods.Method13),
                methodInfo => Instances.IdentityNameProvider.GetIdentityName(methodInfo));

            var expected = Instances.IdentityNames.Method_WithNestedClosedGenericArgument;

            Instances.Assertion.AreEqual(
                expected,
                actual);
        }


        /// <summary>
        /// <inheritdoc cref="ExampleMethods{T}.Method104"/>
        /// </summary>
        [TestMethod]
        public void Method_GenericMethodOnGenericClass()
        {
            var actual = Instances.ReflectedInstanceContextProvider.InExampleMethodContext(
                typeof(ExampleMethods<>),
                "Method104",
                methodInfo => Instances.IdentityNameProvider.GetIdentityName(methodInfo));

            var expected = Instances.IdentityNames.Method_GenericMethodOnGenericClass;

            Instances.Assertion.AreEqual(
                expected,
                actual);
        }

        /// <summary>
        /// <inheritdoc cref="ExampleMethods{T}.Method105"/>
        /// </summary>
        [TestMethod]
        public void Method_GenericMethodOnGenericClass_WithBothGenericTypesAsArguments()
        {
            var actual = Instances.ReflectedInstanceContextProvider.InExampleMethodContext(
                typeof(ExampleMethods<>),
                "Method105",
                methodInfo => Instances.IdentityNameProvider.GetIdentityName(methodInfo));

            var expected = Instances.IdentityNames.Method_GenericMethodOnGenericClass_WithBothGenericTypesAsArguments;

            Instances.Assertion.AreEqual(
                expected,
                actual);
        }

        /// <summary>
        /// <inheritdoc cref="ExampleMethods{T}.Method106"/>
        /// </summary>
        [TestMethod]
        public void Method_GenericMethodOnGenericClass_WithBothGenericTypesAndStringAsArguments()
        {
            var actual = Instances.ReflectedInstanceContextProvider.InExampleMethodContext(
                typeof(ExampleMethods<>),
                "Method106",
                methodInfo => Instances.IdentityNameProvider.GetIdentityName(methodInfo));

            var expected = Instances.IdentityNames.Method_GenericMethodOnGenericClass_WithBothGenericTypesAndStringAsArguments;

            Instances.Assertion.AreEqual(
                expected,
                actual);
        }

        /// <summary>
        /// <inheritdoc cref="ExampleMethods{T}.Method107"/>
        /// </summary>
        [TestMethod]
        public void Method_NestedGenericTypeAsArgument()
        {
            var actual = Instances.ReflectedInstanceContextProvider.InExampleMethodContext(
                typeof(ExampleMethods<>),
                "Method107",
                methodInfo => Instances.IdentityNameProvider.GetIdentityName(methodInfo));

            var expected = Instances.IdentityNames.Method_NestedGenericTypeAsArgument;

            Instances.Assertion.AreEqual(
                expected,
                actual);
        }
    }
}
