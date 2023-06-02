using System;


namespace R5T.L0043.Q000
{
    public class NameDemonstrations : INameDemonstrations
    {
        #region Infrastructure

        public static INameDemonstrations Instance { get; } = new NameDemonstrations();


        private NameDemonstrations()
        {
        }

        #endregion
    }
}
