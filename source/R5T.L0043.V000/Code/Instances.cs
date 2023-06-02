using System;


namespace R5T.L0043.V000
{
    public static class Instances
    {
        public static IEqualityComparers EqualityComparers => V000.EqualityComparers.Instance;
        public static IExpectations Expectations => V000.Expectations.Instance;
        public static F000.INameOperator NameOperator => F000.NameOperator.Instance;
        public static Z001.INameTokens NameTokens => Z001.NameTokens.Instance;
        public static Z001.INames Names => Z001.Names.Instance;
    }
}