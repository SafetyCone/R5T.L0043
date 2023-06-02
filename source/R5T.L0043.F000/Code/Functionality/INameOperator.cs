using System;
using System.Collections.Generic;
using System.Linq;

using R5T.F0124.Extensions;
using R5T.T0132;

using R5T.L0043.T000;
using R5T.L0043.T000.Extensions;


namespace R5T.L0043.F000
{
    [FunctionalityMarker]
    public partial interface INameOperator : IFunctionalityMarker
    {
        public IName Append_Tokens(
            INameTokenSeparator nameTokenSeparator,
            IName name,
            IEnumerable<INameToken> nameTokens)
        {
            var output = this.Combine(
                Name.Constructor,
                nameTokenSeparator,
                nameTokens
                    .AsEnumerable<INamePart>()
                    .Prepend(name));

            return output;
        }

        public IName Append_Tokens(
            IName name,
            IEnumerable<INameToken> nameTokens)
        {
            return this.Append_Tokens(
                Instances.NameTokenSeparators.Default,
                name,
                nameTokens);
        }

        public IName Append_Tokens(
            INameTokenSeparator nameTokenSeparator,
            IName name,
            params INameToken[] nameTokens)
        {
            return this.Append_Tokens(
                nameTokenSeparator,
                name,
                nameTokens.AsEnumerable());
        }

        public IName Append_Tokens(
            IName name,
            params INameToken[] nameTokens)
        {
            return this.Append_Tokens(
                Instances.NameTokenSeparators.Default,
                name,
                nameTokens);
        }

        public IName Append_Token(
            INameTokenSeparator nameTokenSeparator,
            IName name,
            INameToken nameToken)
        {
            return this.Append_Tokens(
                nameTokenSeparator,
                name,
                nameToken);
        }

        public IName Append_Token(
            IName name,
            INameToken nameToken)
        {
            return this.Append_Token(
                Instances.NameTokenSeparators.Default,
                name,
                nameToken);
        }

        public TNamePart Combine<TNamePart>(
            Func<string, TNamePart> outputConstructor,
            INameTokenSeparator nameTokenSeparator,
            IEnumerable<INamePart> nameTokens)
            where TNamePart : INamePart
        {
            // Remove trailing token separators from all tokens, except the last, which is allowed to have a trailing token.
            var endTrimmedNameTokenValues = nameTokens
                .ExceptLast()
                .Select(x => x.Value.Trim_End(nameTokenSeparator.Value))
                .Append(nameTokens.Last().Value)
                .Now();

            // Remote leading token separators from all tokens, except the first, which is allowed to have a leading token.
            var trimmedNameTokenValues = endTrimmedNameTokenValues
                .ExceptFirst()
                .Select(x => x.Trim_Start(nameTokenSeparator.Value))
                .Prepend(endTrimmedNameTokenValues.First())
                .Now();

            var outputValue = Instances.StringOperator.Join(
                nameTokenSeparator.Value,
                trimmedNameTokenValues);

            var output = outputConstructor(outputValue);
            return output;
        }

        public TNamePart Combine<TNamePart>(
            Func<string, TNamePart> outputConstructor,
            INameTokenSeparator nameTokenSeparator,
            params INamePart[] nameTokens)
            where TNamePart : INamePart
        {
            return this.Combine(
                outputConstructor,
                nameTokenSeparator,
                nameTokens.AsEnumerable());
        }

        public IName Combine(
            params INamePart[] nameTokens)
        {
            var output = this.Combine(
                Name.Constructor,
                Instances.NameTokenSeparators.Default,
                nameTokens);

            return output;
        }

        public INameToken[] Get_Tokens(
            INameTokenSeparator nameTokenSeparator,
            INamePart namePart)
        {
            var tokens = Instances.StringOperator.Split(
                nameTokenSeparator.Value,
                namePart.Value)
                .Select(x => x.ToNameToken())
                .Now();

            return tokens;
        }

        public INameToken[] Get_Tokens(INamePart namePart)
        {
            return this.Get_Tokens(
                Instances.NameTokenSeparators.Default,
                namePart);
        }

        public INameToken[] Get_Tokens(
            INameTokenSeparator nameTokenSeparator,
            IName name)
        {
            return this.Get_Tokens(
                nameTokenSeparator,
                name as INameToken);
        }

        public INameToken[] Get_Tokens(IName name)
        {
            return this.Get_Tokens(name as INamePart);
        }
    }
}
