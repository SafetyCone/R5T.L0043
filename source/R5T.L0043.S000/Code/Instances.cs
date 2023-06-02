using System;


namespace R5T.L0043.S000
{
    public static class Instances
    {
        public static O002.INameGenerationOperations NameGenerationOperations => O002.NameGenerationOperations.Instance;
        public static O001.INameOperations NameOperations => O001.NameOperations.Instance;
        public static F000.INameOperator NameOperator => F000.NameOperator.Instance;
        public static Z001.INameTokens NameTokens => Z001.NameTokens.Instance;
        public static Z001.INames Names => Z001.Names.Instance;
    }
}