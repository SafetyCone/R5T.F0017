using System;


namespace R5T.F0017.F002.V000.F000
{
    public class ExamplesAssemblyFilePathProvider : IExamplesAssemblyFilePathProvider
    {
        #region Infrastructure

        public static ExamplesAssemblyFilePathProvider Instance { get; } = new();

        private ExamplesAssemblyFilePathProvider()
        {
        }

        #endregion
    }
}
