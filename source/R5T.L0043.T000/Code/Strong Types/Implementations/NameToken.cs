using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.L0043.T000
{
    /// <inheritdoc cref="INameToken"/>
    [StrongTypeImplementationMarker]
    public class NameToken : TypedBase<string>, IStrongTypeMarker,
        INameToken
    {
        public NameToken(string value)
            : base(value)
        {
        }
    }
}