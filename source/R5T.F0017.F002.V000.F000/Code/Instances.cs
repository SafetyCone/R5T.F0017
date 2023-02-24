using System;


namespace R5T.F0017.F002.V000.F000
{
    public static class Instances
    {
        public static IExamplesAssemblyFilePathProvider ExamplesAssemblyFilePathProvider { get; } = F000.ExamplesAssemblyFilePathProvider.Instance;
        public static F0000.IExecutablePaths ExecutablePaths => F0000.ExecutablePaths.Instance;
        public static F0002.IPathOperator PathOperator { get; } = F0002.PathOperator.Instance;
        public static F0018.IReflectionOperator ReflectionOperator { get; } = F0018.ReflectionOperator.Instance;
    }
}