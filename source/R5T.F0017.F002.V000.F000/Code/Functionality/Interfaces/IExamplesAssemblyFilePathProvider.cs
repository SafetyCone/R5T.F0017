using System;

using R5T.Magyar;

using R5T.T0132;


namespace R5T.F0017.F002.V000.F000
{
    [FunctionalityMarker]
    public interface IExamplesAssemblyFilePathProvider : IFunctionalityMarker
    {
        public string GetExecutableDirectoryPath()
        {
            var executableFilePath = ExecutableFilePathHelper.GetExecutableFilePath();

            var output = Instances.PathOperator.GetDirectoryPathOfFilePath(executableFilePath);
            return output;
        }

        public string GetExamplesAssemblyFilePath()
        {
            var executableDirectoryPath = this.GetExecutableDirectoryPath();

            var output = Instances.PathOperator.GetFilePath(
                executableDirectoryPath,
                "R5T.F0017.F002.V000.T000.dll");

            return output;
        }
    }
}
