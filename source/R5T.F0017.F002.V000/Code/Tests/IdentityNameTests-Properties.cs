using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using R5T.T0140;


namespace R5T.F0017.F002.V000
{
    public partial class IdentityNameTests
    {
        /// <summary>
        /// <inheritdoc cref="ExampleProperties.Property01"/>
        /// </summary>
        [TestMethod]
        public void Property_Basic()
        {
            var actual = Instances.ReflectedInstanceContextProvider.InExamplePropertyContext(
                typeof(ExampleProperties),
                nameof(ExampleProperties.Property01),
                propertyInfo => Instances.IdentityNameProvider.GetIdentityName(propertyInfo));

            var expected = Instances.IdentityNames.Property_Basic;

            Instances.Assertion.AreEqual(
                expected,
                actual);
        }

        /// <summary>
        /// <inheritdoc cref="ExampleProperties{T}.Property20"/>
        /// </summary>
        [TestMethod]
        public void Property_OnGenericClass()
        {
            var actual = Instances.ReflectedInstanceContextProvider.InExamplePropertyContext(
                typeof(ExampleProperties<>),
                // Name is needed due to bad behavior of nameof() operator with open generics.
                "Property20",
                propertyInfo => Instances.IdentityNameProvider.GetIdentityName(propertyInfo));

            var expected = Instances.IdentityNames.Property_OnGenericClass;

            Instances.Assertion.AreEqual(
                expected,
                actual);
        }
    }
}
