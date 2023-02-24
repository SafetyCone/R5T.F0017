using System;


namespace R5T.F0017.F002.V000
{
    public class IdentityNames : IIdentityNames
    {
        #region Infrastructure

        public static IIdentityNames Instance { get; } = new IdentityNames();


        private IdentityNames()
        {
        }

        #endregion
    }
}
