using System;


namespace R5T.F0017.F002
{
    public class IdentityNameProvider : IIdentityNameProvider
    {
        #region Infrastructure

        public static IdentityNameProvider Instance { get; } = new();

        private IdentityNameProvider()
        {
        }

        #endregion
    }
}
