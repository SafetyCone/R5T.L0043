using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.L0043.T000
{
    /// <summary>
    /// Strongly-types a string as an unadjusted name.
    /// Names might be adjusted for a variety of reasons, chief among which is to reflect that the name refers to a private asset by appending the private signifier token.
    /// </summary>
    /// <remarks>
    /// Does not inherit from <see cref="IName"/> to disallow substituting an unadjusted name for a name when a method requires a name.
    /// In fact, an unadjusted name is not even a <see cref="INamePart"/>.
    /// </remarks>
    [StrongTypeMarker]
    public interface IUnadjustedName : IStrongTypeMarker,
        ITyped<string>
    {
    }
}