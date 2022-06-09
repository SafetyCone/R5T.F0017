using System;


namespace R5T.F0017.F002.V000.Z000
{
    public class IdentityNames : IIdentityNames
    {
        #region Infrastructure

        public static IdentityNames Instance { get; } = new();

        private IdentityNames()
        {
        }

        #endregion
    }
}
