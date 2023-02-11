using System;

namespace Shuttle.Core.System
{
    public interface ISystemClock
    {
        DateTimeOffset UtcNow { get; }
    }
}