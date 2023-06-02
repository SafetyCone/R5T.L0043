using System;


namespace R5T.L0043.Z002
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
