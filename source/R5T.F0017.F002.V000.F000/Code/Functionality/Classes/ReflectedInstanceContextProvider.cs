using System;


namespace R5T.F0017.F002.V000.F000
{
    public class ReflectedInstanceContextProvider : IReflectedInstanceContextProvider
    {
        #region Infrastructure

        public static ReflectedInstanceContextProvider Instance { get; } = new();

        private ReflectedInstanceContextProvider()
        {
        }

        #endregion
    }
}
