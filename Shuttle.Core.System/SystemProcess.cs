using System.Diagnostics;
using Shuttle.Core.Contract;

namespace Shuttle.Core.System
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