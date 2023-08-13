using System;

using R5T.T0132;


namespace R5T.T0224.Extensions
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        /// <inheritdoc cref="IUrl"/>
        public IUrl ToUrl(string value)
        {
            var output = new Url(value);
            return output;
        }
    }
}
