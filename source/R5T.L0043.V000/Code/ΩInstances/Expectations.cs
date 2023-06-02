using System;


namespace R5T.L0043.V000
{
    public class Expectations : IExpectations
    {
        #region Infrastructure

        public static IExpectations Instance { get; } = new Expectations();


        private Expectations()
        {
        }

        #endregion
    }
}
