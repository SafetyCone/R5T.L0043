using System;

using R5T.T0178;


namespace R5T.L0043.T000
{
    /// <summary>
    /// Strongly-types a string as a name token separator.
    /// </summary>
    [StrongTypeMarker]
    public interface INameTokenSeparator : IStrongTypeMarker,
        T0185.ITokenSeparator
    {
    }
}