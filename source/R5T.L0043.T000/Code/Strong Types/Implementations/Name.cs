using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.L0043.T000
{
    /// <inheritdoc cref="IName"/>
    [StrongTypeImplementationMarker]
    public class Name : TypedBase<string>, IStrongTypeMarker,
        IName
    {
        #region Static

        public static Name Constructor(string value)
        {
            return new Name(value);
        }

        #endregion


        public Name(string value)
            : base(value)
        {
        }
    }
}