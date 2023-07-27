using System;

using R5T.T0178; /// <see cref="R5T.T0178.Documentation"/>


namespace R5T.L0043.T000
{
    /// <summary>
    /// Strongly-types a string as a name that can be tokenized into parts using a token separator.
    /// As opposed to <see cref="T0185.IName"/>, which could be anything from the name of a person the name of a abstract code element,
    /// this type is for names that can be tokenized into parts using a token separator. 
    /// This is useful for things like Visual Studio project and solution names.
    /// </summary>
    [StrongTypeMarker]
    public interface IName : IStrongTypeMarker,
        T0185.IName,
        INamePart
    {
    }
}