using System;


namespace R5T.F0017.F002.V000.T000
{
    /// <summary>
    /// <inheritdoc cref="ExampleClass00" path="/description"/>
    /// <provides-ID-string>It provides a XML documentation ID string the project's XML documentation file for the output assembly.</provides-ID-string>
    /// </summary>
    /// <description>Basic example class.</description>
    public class ExampleClass00
    { }

    /// <summary>
    /// <inheritdoc cref="ExampleClass01{T}" path="/description"/>
    /// <inheritdoc cref="ExampleClass00" path="/summary/provides-ID-string"/>
    /// </summary>
    /// <description>Example class with one generic type paramter.</description>
    public class ExampleClass01<T>
    { }

    /// <summary>
    /// <inheritdoc cref="ExampleClass02{T1, T2}" path="/description"/>
    /// <inheritdoc cref="ExampleClass00" path="/summary/provides-ID-string"/>
    /// </summary>
    /// <description>Example class with two generic type parameters.</description>
    public class ExampleClass02<T1, T2>
    { }

    /// <summary>
    /// <inheritdoc cref="ExampleClass03" path="/description"/>
    /// <inheritdoc cref="ExampleClass00" path="/summary/provides-ID-string"/>
    /// </summary>
    /// <description>Basic static example class.</description>
    public static class ExampleClass03
    { }

    /// <summary>
    /// <inheritdoc cref="ExampleClass04{T}" path="/description"/>
    /// <inheritdoc cref="ExampleClass00" path="/summary/provides-ID-string"/>
    /// </summary>
    /// <description>Static example class with one type parameter.</description>
    public static class ExampleClass04<T>
    { }
}
