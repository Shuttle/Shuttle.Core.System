namespace Shuttle.Platform;

public interface ISystemClock
{
    DateTimeOffset UtcNow { get; }
}