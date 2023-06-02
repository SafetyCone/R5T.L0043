using System;


namespace R5T.L0043.Z001
{
    public class Names : INames
    {
        #region Infrastructure

        public static INames Instance { get; } = new Names();


        private Names()
        {
        }

        #endregion
    }
}
