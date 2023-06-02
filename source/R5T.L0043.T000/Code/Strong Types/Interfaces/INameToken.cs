using System;

using R5T.T0178;


namespace R5T.L0043.T000
{
    /// <summary>
    /// Strongly-types a string as a token of a name (<see cref="IName"/>).
    /// </summary>
    [StrongTypeMarker]
    public interface INameToken : IStrongTypeMarker,
        T0185.IToken,
        INamePart
    {
    }
}