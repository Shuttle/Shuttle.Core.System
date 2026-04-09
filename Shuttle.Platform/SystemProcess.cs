using System.Diagnostics;
using Shuttle.Contract;

namespace Shuttle.Platform
{
    public class SystemProcess(Process process) : IProcess
    {
        private readonly Process _process = Guard.AgainstNull(process);

        public void Kill()
        {
            _process.Kill();
        }
    }
}