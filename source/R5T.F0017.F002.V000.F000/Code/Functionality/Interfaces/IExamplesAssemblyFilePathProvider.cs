using System;

using R5T.T0132;


namespace R5T.F0017.F002.V000.F000
{
    [FunctionalityMarker]
    public interface IExamplesAssemblyFilePathProvider : IFunctionalityMarker
    {
        public string GetExamplesAssemblyFilePath()
        {
            var output = Instances.PathOperator.GetFilePath(
                Instances.ExecutablePaths.ExecutableDirectoryPath,
                "R5T.T0140.dll");

            return output;
        }
    }
}
