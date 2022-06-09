using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace R5T.F0017.F002.V000
{
    public partial class IdentityNameTests
    {
        /// <summary>
        /// <inheritdoc cref="T000.ExampleProperties.Property01"/>
        /// </summary>
        [TestMethod]
        public void Property01()
        {
            var actual = Instances.ReflectedInstanceContextProvider.InExamplePropertyContext(
                typeof(T000.ExampleProperties),
                nameof(T000.ExampleProperties.Property01),
                propertyInfo => Instances.IdentityNameProvider.GetIdentityName(propertyInfo));

            var expected = Instances.IdentityNames.Property01;

            Instances.Assertion.AreEqual(
                actual,
                expected);
        }

        /// <summary>
        /// <inheritdoc cref="T000.ExampleProperties{T}.Property20"/>
        /// </summary>
        [TestMethod]
        public void Property20()
        {
            var actual = Instances.ReflectedInstanceContextProvider.InExamplePropertyContext(
                typeof(T000.ExampleProperties<>),
                "Property20",
                propertyInfo => Instances.IdentityNameProvider.GetIdentityName(propertyInfo));

            var expected = Instances.IdentityNames.Property20;

            Instances.Assertion.AreEqual(
                actual,
                expected);
        }
    }
}
