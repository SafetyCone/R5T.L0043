using System;


namespace R5T.L0043.S000
{
    public class NameOperationScripts : INameOperationScripts
    {
        #region Infrastructure

        public static INameOperationScripts Instance { get; } = new NameOperationScripts();


        private NameOperationScripts()
        {
        }

        #endregion
    }
}
