using System;


namespace R5T.L0043.Z001
{
    public class NameTokens : INameTokens
    {
        #region Infrastructure

        public static INameTokens Instance { get; } = new NameTokens();


        private NameTokens()
        {
        }

        #endregion
    }
}
