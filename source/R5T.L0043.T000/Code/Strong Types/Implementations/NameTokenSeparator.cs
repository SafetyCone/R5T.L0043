using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.L0043.T000
{
    /// <inheritdoc cref="INameTokenSeparator"/>
    [StrongTypeImplementationMarker]
    public class NameTokenSeparator : TypedBase<string>, IStrongTypeMarker,
        INameTokenSeparator
    {
        public NameTokenSeparator(string value)
            : base(value)
        {
        }
    }
}