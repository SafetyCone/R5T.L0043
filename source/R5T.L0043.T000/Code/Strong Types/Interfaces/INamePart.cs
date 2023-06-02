using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.L0043.T000
{
    /// <summary>
    /// Strongly-types a string as a part of a name (<see cref="IName"/>).
    /// A name part contains zero or more name tokens (<see cref="INameToken"/>) separated by name token separators (<see cref="INameTokenSeparator"/>).
    /// </summary>
    [StrongTypeMarker]
    public interface INamePart : IStrongTypeMarker,
        ITyped<string>
    {
    }
}