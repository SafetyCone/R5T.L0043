using System;

using R5T.T0132;


namespace R5T.L0043.S000
{
    [FunctionalityMarker]
    public partial interface INameOperationScripts : IFunctionalityMarker
    {
        public void AdjustForPrivacy()
        {
            /// Inputs.
            var name = Instances.Names.Example_A;
            var isPrivate = true;


            /// Run.
            var adjustedName = Instances.NameOperations.Adjust_ForPrivacy(
                name,
                isPrivate);

            Console.WriteLine($"{adjustedName}: {isPrivate}, is private, privacy adjusted name");
        }
    }
}
