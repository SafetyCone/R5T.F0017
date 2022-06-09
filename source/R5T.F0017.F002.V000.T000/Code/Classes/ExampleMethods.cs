using System;
using System.Collections.Generic;

using R5T.T0140;


namespace R5T.F0017.F002.V000.T000
{
    /// <summary>
    /// A class providing example methods.
    /// </summary>
    public class ExampleMethods
    {
        /// <summary>
        /// Static method returning void.
        /// </summary>
        public static void Method01()
        { }

        /// <summary>
        /// Static method returning a string.
        /// </summary>
        /// <returns></returns>
        public static string Method02()
        {
            return String.Empty;
        }

        /// <summary>
        /// Static method with one type parameter.
        /// </summary>
        public static void Method03<T>()
        { }

        /// <summary>
        /// Static method with two type parameters.
        /// </summary>
        public static void Method04<T1, T2>()
        { }

#pragma warning disable CA1822 // Mark members as static

        /// <summary>
        /// Method retuning void.
        /// </summary>
        public void Method05()
        { }

        /// <summary>
        /// Method returning a string.
        /// </summary>
        public string Method06()
        {
            return String.Empty;
        }

        /// <summary>
        /// Method with one generic type parameter.
        /// </summary>
        public void Method06<T>()
        { }

        /// <summary>
        /// Method with two generic type parameters.
        /// </summary>
        public void Method06<T1, T2>()
        { }

        /// <summary>
        /// Method returning a generic type parameter.
        /// </summary>
        public T Method07<T>()
        {
            var output = (T)(new object());
            return output;
        }

        /// <summary>
        /// Method taking a string and returning a string.
        /// </summary>
        public string Method08(string value)
        {
            return value;
        }

        /// <summary>
        /// Method taking a generic type instance and returning a generic type instance.
        /// </summary>
        public T Method09<T>(T value)
        {
            return value;
        }

        /// <summary>
        /// Method with new() restriction on generic type parameter.
        /// </summary>
        public void Method10<T>()
            where T : new()
        { }

        /// <summary>
        /// Method with class restriction on generic type parameter.
        /// </summary>
        public void Method11<T>()
            where T : class
        { }

        /// <summary>
        /// Method with specific class restriction on generic type parameter.
        /// </summary>
        public void Method12<T>()
            where T : Class01
        { }

#pragma warning restore CA1822 // Mark members as static

    }

    /// <summary>
    /// A generic class providing example methods.
    /// </summary>
    public class ExampleMethods<T>
    {
        /// <summary>
        /// Basic method.
        /// </summary>
        public void Method101()
        { }

        /// <summary>
        /// Method taking a string.
        /// </summary>
// Allow unused parameter to stay to see if reflection contains any information on the parameter name.
#pragma warning disable IDE0060 // Remove unused parameter
        public void Method102(string value)
#pragma warning restore IDE0060 // Remove unused parameter
        { }

        /// <summary>
        /// Method taking one parameter.
        /// </summary>
        public void Method103(T _)
        { }

        /// <summary>
        /// Method with one generic type parameter.
        /// </summary>
        public void Method104<T1>()
        { }

        /// <summary>
        /// Method with one generic type parameter, taking the type generic type parameter and the method generic type parameter.
        /// </summary>
#pragma warning disable IDE0060 // Remove unused parameter
        public void Method105<T1>(T t, T1 t1)
#pragma warning restore IDE0060 // Remove unused parameter
        { }

        /// <summary>
        /// Method with one generic type parameter, taking the type generic type parameter, the method generic type parameter, and a string.
        /// </summary>
#pragma warning disable IDE0060 // Remove unused parameter
        public void Method106<T1>(T t, T1 t1, string @string)
#pragma warning restore IDE0060 // Remove unused parameter
        { }

        /// <summary>
        /// Nested generic types.
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <param name="value"></param>
#pragma warning disable IDE0060 // Remove unused parameter
        public void Method107<T1>(Func<Dictionary<T, IEnumerable<T1>>> value)
#pragma warning restore IDE0060 // Remove unused parameter
        { }
    }
}
