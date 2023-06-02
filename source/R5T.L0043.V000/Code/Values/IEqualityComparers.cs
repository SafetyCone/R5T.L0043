using System;

using R5T.F0000.T000;
using R5T.T0131;

using R5T.L0043.T000;


namespace R5T.L0043.V000
{
    [ValuesMarker]
    public partial interface IEqualityComparers : IValuesMarker
    {
        public IEqualityComparer<IName> For_IName => new FunctionBasedEqualityComparer<IName>(
            (a, b) => a.Equals(b));
    }
}
