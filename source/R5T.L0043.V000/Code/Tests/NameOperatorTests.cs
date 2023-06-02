using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using R5T.F0101.Extensions;


namespace R5T.L0043.V000
{
    [TestClass]
    public class NameOperatorTests
    {
        [TestMethod]
        public void Combine_NameTokens()
        {
            var expectation = Instances.Expectations.Combine_NameTokens;

            expectation.Assert(Instances.NameOperator.Combine);
        }
    }
}
