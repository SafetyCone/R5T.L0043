using System;

using R5T.T0141;


namespace R5T.L0043.Q000
{
    [DemonstrationsMarker]
    public partial interface INameDemonstrations : IDemonstrationsMarker
    {
        public void Combine_NameTokens()
        {
            /// Inputs.
            var nameTokens = Instances.NameTokens.Examples_ABC;

            /// Run.
            var name = Instances.NameOperator.Combine(nameTokens);

            Console.WriteLine($"{name}: name from combined name tokens");
        }
    }
}
