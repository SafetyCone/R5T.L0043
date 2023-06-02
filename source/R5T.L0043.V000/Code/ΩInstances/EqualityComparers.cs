using System;


namespace R5T.L0043.V000
{
    public class EqualityComparers : IEqualityComparers
    {
        #region Infrastructure

        public static IEqualityComparers Instance { get; } = new EqualityComparers();


        private EqualityComparers()
        {
        }

        #endregion
    }
}
