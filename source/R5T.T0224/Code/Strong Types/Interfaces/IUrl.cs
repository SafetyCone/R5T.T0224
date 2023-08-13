using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0224
{
    /// <summary>
    /// Strongly-types a string as a URL.
    /// </summary>
    [StrongTypeMarker]
    public interface IUrl : IStrongTypeMarker,
        ITyped<string>
    {
    }
}