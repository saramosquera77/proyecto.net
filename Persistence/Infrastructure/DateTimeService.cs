using Application.Interfaces;
using System;

namespace Persistence.Infrastructure
{
    public class DateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}
