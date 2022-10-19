using System;


namespace R5T.F0017.F002
{
    public class IdentityNameProvider : IIdentityNameProvider
    {
        #region Infrastructure

        public static IIdentityNameProvider Instance { get; } = new IdentityNameProvider();

        private IdentityNameProvider()
        {
        }

        #endregion
    }
}
