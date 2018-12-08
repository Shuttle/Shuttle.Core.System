using System;

namespace Shuttle.Core.System
{
    public class EnvironmentService : IEnvironmentService
    {
        public bool UserInteractive => Environment.UserInteractive;
    }
}