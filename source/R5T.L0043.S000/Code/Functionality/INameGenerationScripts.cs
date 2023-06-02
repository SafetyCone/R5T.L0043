using System;

using R5T.T0132;


namespace R5T.L0043.S000
{
    [FunctionalityMarker]
    public partial interface INameGenerationScripts : IFunctionalityMarker
    {
        public void Get_ConstructionName()
        {
            /// Inputs.
            var name = Instances.Names.Example_A;

            /// Run.
            var constructionName = Instances.NameGenerationOperations.Get_ConstructionName(name);

            Console.WriteLine($"{constructionName}: construction name for '{name}'");
        }
    }
}
