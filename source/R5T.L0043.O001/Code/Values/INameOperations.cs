using System;

using R5T.T0131;

using R5T.L0043.T000;
using R5T.L0043.T000.Extensions;


namespace R5T.L0043.O001
{
    [ValuesMarker]
    public partial interface INameOperations : IValuesMarker
    {
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
            var output = Instances.NameOperator.Append_Token(
                name,
                Instances.NameTokens.Private);

            return output;
        }
    }
}
