using System;


namespace R5T.F0017.F002.V000.T000
{
    /// <summary>
    /// A class providing example properties.
    /// </summary>
    public class ExampleProperties
    {
        /// <summary>
        /// Property with get and set;
        /// </summary>
        public string Property01 { get; set; }
        /// <summary>
        /// Property with get and private set.
        /// </summary>
        public string Property02 { get; private set; }
        /// <summary>
        /// Property with get only.
        /// </summary>
        public string Property03 { get; }

#pragma warning disable IDE0052 // Remove unread private members
        private string zProperty04;
#pragma warning restore IDE0052 // Remove unread private members
        /// <summary>
        /// Property with backing field.
        /// </summary>
        public string Property04
        {
            set
            {
                zProperty04 = value;
            }
        }

        // Properties cannot be generic on non-generic classes.
        //public T Property<T> { get; }

        /// <summary>
        /// An indexer for string.
        /// </summary>
#pragma warning disable CA1822 // Mark members as static
        public string this[string test] => test;
#pragma warning restore CA1822 // Mark members as static

        /// <summary>
        /// An indexer for int.
        /// </summary>
#pragma warning disable CA1822 // Mark members as static
        public int this[int test] => test;
#pragma warning restore CA1822 // Mark members as static

        // Indexers cannot be generic on non-generic classes.
        //public T this<T>[T value] => value;

        /// <summary>
        /// Static property with get and set.
        /// </summary>
        public static string Property10 { get; set; }
    }


    /// <summary>
    /// A generic class providing example properties.
    /// </summary>
    public class ExampleProperties<T>
    {
        /// <summary>
        /// A property on a generic class.
        /// </summary>
        public static string Property20 { get; set; }

        /// <summary>
        /// A generic property on a generic class.
        /// </summary>
        public static T Property21 { get; }

        /// <summary>
        /// An indexer for string on a generic class.
        /// </summary>
#pragma warning disable CA1822 // Mark members as static
        public string this[string test] => test;
#pragma warning restore CA1822 // Mark members as static

        /// <summary>
        /// An indexer for a generic type on a generic class.
        /// </summary>
#pragma warning disable CA1822 // Mark members as static
        public T this[T test] => test;
#pragma warning restore CA1822 // Mark members as static

        // Properties cannot be generic beyond their generic classes.
        //public static T Property<T2> { get; }
    }
}
