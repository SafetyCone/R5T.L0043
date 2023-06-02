using System;


namespace R5T.L0043.Z000
{
    public class NameTokenSeparators : INameTokenSeparators
    {
        #region Infrastructure

        public static INameTokenSeparators Instance { get; } = new NameTokenSeparators();


        private NameTokenSeparators()
        {
        }

        #endregion
    }
}
