using System;

using R5T.T0120;
using R5T.T0131;

using R5T.L0043.T000;


namespace R5T.L0043.V000
{
    [ValuesMarker]
    public partial interface IExpectations : IValuesMarker
    {
        public IExpectation<INameToken[], IName> Combine_NameTokens => new Expectation<INameToken[], IName>
        {
            Input = Instances.NameTokens.Examples_ABC,
            Output = Instances.Names.Example_ABC,
            OutputEqualityComparer = Instances.EqualityComparers.For_IName,
        };
    }
}
