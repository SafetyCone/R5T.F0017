using System;


namespace R5T.F0017.F002
{
    public class ParameterNamedIdentityNameProvider : IParameterNamedIdentityNameProvider
    {
        #region Infrastructure

        public static IParameterNamedIdentityNameProvider Instance { get; } = new ParameterNamedIdentityNameProvider();


        private ParameterNamedIdentityNameProvider()
        {
        }

        #endregion
    }
}
