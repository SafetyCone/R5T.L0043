using System;

using R5T.T0132;


namespace R5T.L0043.S000
{
    [FunctionalityMarker]
    public partial interface INameScripts : IFunctionalityMarker
    {
        public void Combine_NameTokens()
        {
            /// Inputs.
            var nameTokens = Instances.NameTokens.Examples_ABC;

            /// Run.
            var name = Instances.NameOperator.Combine(
                nameTokens);

            Console.WriteLine($"{name}: name");
        }
    }
}
