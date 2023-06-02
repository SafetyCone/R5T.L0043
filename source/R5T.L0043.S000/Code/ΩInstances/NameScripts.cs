using System;


namespace R5T.L0043.S000
{
    public class NameScripts : INameScripts
    {
        #region Infrastructure

        public static INameScripts Instance { get; } = new NameScripts();


        private NameScripts()
        {
        }

        #endregion
    }
}
