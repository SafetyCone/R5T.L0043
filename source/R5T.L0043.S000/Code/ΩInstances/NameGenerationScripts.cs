using System;


namespace R5T.L0043.S000
{
    public class NameGenerationScripts : INameGenerationScripts
    {
        #region Infrastructure

        public static INameGenerationScripts Instance { get; } = new NameGenerationScripts();


        private NameGenerationScripts()
        {
        }

        #endregion
    }
}
