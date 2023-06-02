using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.L0043.T000
{
    /// <inheritdoc cref="IUnadjustedName"/>
    [StrongTypeImplementationMarker]
    public class UnadjustedName : TypedBase<string>, IStrongTypeMarker,
        IUnadjustedName
    {
        public UnadjustedName(string value)
            : base(value)
        {
        }
    }
}