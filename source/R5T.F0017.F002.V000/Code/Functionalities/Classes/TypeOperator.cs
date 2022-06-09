using System;


namespace R5T.F0017.F002.V000.Functionalities
{
    public class TypeOperator : ITypeOperator
    {
        #region Infrastructure

        public static TypeOperator Instance { get; } = new();

        private TypeOperator()
        {
        }

        #endregion
    }
}
