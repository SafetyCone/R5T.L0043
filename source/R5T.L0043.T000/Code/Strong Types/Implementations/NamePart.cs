using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.L0043.T000
{
    /// <inheritdoc cref="INamePart"/>
    [StrongTypeImplementationMarker]
    public class NamePart : TypedBase<string>, IStrongTypeMarker,
        INamePart
    {
        public NamePart(string value)
            : base(value)
        {
        }
    }
}