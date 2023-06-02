using System;


namespace R5T.L0043.O001
{
    public class NameOperations : INameOperations
    {
        #region Infrastructure

        public static INameOperations Instance { get; } = new NameOperations();


        private NameOperations()
        {
        }

        #endregion
    }
}
