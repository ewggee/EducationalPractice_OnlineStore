﻿namespace OnlineStore.Core.Common.DateTimeProviders
{
    /// <summary>
    /// Провайдер времени.
    /// </summary>
    public sealed class DateTimeProvider : IDateTimeProvider
    {
        /// <inheritdoc/>
        public DateTime UtcNow => DateTime.UtcNow;
    }
}
