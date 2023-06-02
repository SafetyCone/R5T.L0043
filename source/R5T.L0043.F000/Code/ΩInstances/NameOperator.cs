using System;


namespace R5T.L0043.F000
{
    public class NameOperator : INameOperator
    {
        #region Infrastructure

        public static INameOperator Instance { get; } = new NameOperator();


        private NameOperator()
        {
        }

        #endregion
    }
}
