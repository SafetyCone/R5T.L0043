using System;

using R5T.T0131;

using R5T.L0043.T000;
using R5T.L0043.T000.Extensions;


namespace R5T.L0043.Z001
{
    [ValuesMarker]
    public partial interface INames : IValuesMarker
    {
        public IName Example_A => "Example_A".ToName();
        public IName Example_A_Private => "Example_A.Private".ToName();
        public IName Example_ABC => "ExampleA.ExampleB.ExampleC".ToName();
    }
}
