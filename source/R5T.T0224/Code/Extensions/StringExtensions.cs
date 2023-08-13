using System;


namespace R5T.T0224.Extensions
{
    public static class StringExtensions
    {
        /// <inheritdoc cref="IStringOperator.ToUrl(string)"/>
        public static IUrl ToUrl(this string value)
        {
            return Instances.StringOperator_Extensions.ToUrl(value);
        }
    }
}
