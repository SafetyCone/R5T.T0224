using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0224
{
    /// <inheritdoc cref="IUrl"/>
    [StrongTypeImplementationMarker]
    public class Url : TypedBase<string>, IStrongTypeMarker,
        IUrl
    {
        public Url(string value)
            : base(value)
        {
        }
    }
}