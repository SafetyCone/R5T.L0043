using System;

using R5T.T0131;

using R5T.L0043.T000;
using R5T.L0043.T000.Extensions;


namespace R5T.L0043.Z001
{
    [ValuesMarker]
    public partial interface INameTokens : IValuesMarker
    {
        public INameToken Example_A => "ExampleA".ToNameToken();
        public INameToken Example_B => "ExampleB".ToNameToken();
        public INameToken Example_C => "ExampleC".ToNameToken();


        public INameToken[] Examples_ABC => new[]
        {
            this.Example_A,
            this.Example_B,
            this.Example_C,
        };
    }
}
