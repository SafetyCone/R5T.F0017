using System;


namespace R5T.F0017.F002.V000
{
    public class ParameterNamedIdentityNames : IParameterNamedIdentityNames
    {
        #region Infrastructure

        public static IParameterNamedIdentityNames Instance { get; } = new ParameterNamedIdentityNames();


        private ParameterNamedIdentityNames()
        {
        }

        #endregion
    }
}
