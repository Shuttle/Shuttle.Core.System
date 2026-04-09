namespace Shuttle.Platform;

public class EnvironmentService : IEnvironmentService
{
    public bool UserInteractive => Environment.UserInteractive;
}