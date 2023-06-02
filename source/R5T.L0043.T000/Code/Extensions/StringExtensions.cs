using System;


namespace R5T.L0043.T000.Extensions
{
    public static class StringExtensions
    {
        /// <inheritdoc cref="IStringOperator.ToName(string)"/>
        public static IName ToName(this string value)
        {
            return Instances.StringOperator_Extensions.ToName(value);
        }

        /// <inheritdoc cref="IStringOperator.ToNamePart(string)"/>
        public static INamePart ToNamePart(this string value)
        {
            return Instances.StringOperator_Extensions.ToNamePart(value);
        }

        /// <inheritdoc cref="IStringOperator.ToNameToken(string)"/>
        public static INameToken ToNameToken(this string value)
        {
            return Instances.StringOperator_Extensions.ToNameToken(value);
        }

        /// <inheritdoc cref="IStringOperator.ToNameTokenSeparator(string)"/>
        public static INameTokenSeparator ToNameTokenSeparator(this string value)
        {
            return Instances.StringOperator_Extensions.ToNameTokenSeparator(value);
        }

        /// <inheritdoc cref="IStringOperator.ToUnadjustedName(string)"/>
        public static IUnadjustedName ToUnadjustedName(this string value)
        {
            return Instances.StringOperator_Extensions.ToUnadjustedName(value);
        }
    }
}
