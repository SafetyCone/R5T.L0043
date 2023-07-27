using System;

using R5T.T0132;

using R5T.L0043.T000;
using R5T.L0043.T000.Extensions;


namespace R5T.L0043.F001
{
    [FunctionalityMarker]
    public partial interface INameOperator : IFunctionalityMarker
    {
        private static F000.INameOperator F000 => L0043.F000.NameOperator.Instance;


        public IName Adjust_ForPrivacy(
            string name,
            bool isPrivate)
        {
            return this.Adjust_ForPrivacy(
                name.ToName(),
                isPrivate);
        }

        public TOutput Adjust_ForPrivacy<TOutput>(
            string name,
            bool isPrivate,
            Func<string, TOutput> outputConstructor)
        {
            var adjustedName = this.Adjust_ForPrivacy(
                name.ToName(),
                isPrivate);

            var output = outputConstructor(
                adjustedName.Value);

            return output;
        }

        public IName Adjust_ForPrivacy(
            IName name,
            bool isPrivate)
        {
            var output = isPrivate
                ? this.Make_Private(name)
                : name
                ;

            return output;
        }

        public IName Adjust_ForPrivacy(
            IUnadjustedName unadjustedName,
            bool isPrivate)
        {
            var name = unadjustedName.Value.ToName();

            return this.Adjust_ForPrivacy(
                name,
                isPrivate);
        }

        public IName Make_Private(IName name)
        {
            var output = F000.Append_Token(
                name,
                Instances.NameTokens.Private);

            return output;
        }
    }
}
