using System;

using R5T.T0131;

using R5T.L0043.T000;
using R5T.L0043.T000.Extensions;


namespace R5T.L0043.Z000
{
    [ValuesMarker]
    public partial interface INameTokenSeparators : IValuesMarker
    {
        public INameTokenSeparator Default => this.Period;

        public INameTokenSeparator Period => Instances.Strings.Period.ToNameTokenSeparator();
    }
}
