using System;

using R5T.T0132;


namespace R5T.L0043.T000.Extensions
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        /// <inheritdoc cref="IName"/>
        public IName ToName(string value)
        {
            var output = new Name(value);
            return output;
        }

        /// <inheritdoc cref="INamePart"/>
        public INamePart ToNamePart(string value)
        {
            var output = new NamePart(value);
            return output;
        }

        /// <inheritdoc cref="INameToken"/>
        public INameToken ToNameToken(string value)
        {
            var output = new NameToken(value);
            return output;
        }

        /// <inheritdoc cref="INameTokenSeparator"/>
        public INameTokenSeparator ToNameTokenSeparator(string value)
        {
            var output = new NameTokenSeparator(value);
            return output;
        }

        /// <inheritdoc cref="IUnadjustedName"/>
        public IUnadjustedName ToUnadjustedName(string value)
        {
            var output = new UnadjustedName(value);
            return output;
        }
    }
}
