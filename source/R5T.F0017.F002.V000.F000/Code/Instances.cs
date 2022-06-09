using System;


namespace R5T.F0017.F002.V000.F000
{
    public static class Instances
    {
        public static IExamplesAssemblyFilePathProvider ExamplesAssemblyFilePathProvider { get; } = F000.ExamplesAssemblyFilePathProvider.Instance;
        public static T0041.IPathOperator PathOperator { get; } = T0041.PathOperator.Instance;
        public static F0018.IReflectionOperator ReflectionOperator { get; } = F0018.ReflectionOperator.Instance;
    }
}