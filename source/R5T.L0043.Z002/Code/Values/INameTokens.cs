using System;

using R5T.T0131;

using R5T.L0043.T000;
using R5T.L0043.T000.Extensions;


namespace R5T.L0043.Z002
{
    [ValuesMarker]
    public partial interface INameTokens : IValuesMarker
    {
        public INameToken Construction => Instances.Words.Construction.Value.ToNameToken();
        public INameToken Private => Instances.Words.Private.Value.ToNameToken();
    }
}
