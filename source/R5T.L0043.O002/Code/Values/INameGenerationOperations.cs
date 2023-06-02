using System;

using R5T.T0131;

using R5T.L0043.T000;


namespace R5T.L0043.O002
{
    [ValuesMarker]
    public partial interface INameGenerationOperations : IValuesMarker
    {
        public IName Get_ConstructionName(IName name)
        {
            var output = Instances.NameOperator.Append_Token(
                name,
                Instances.NameTokens.Construction);

            return output;
        }
    }
}
