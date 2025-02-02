using System.Diagnostics;
using Shuttle.Core.Contract;

namespace Shuttle.Core.System
{
    public class SystemProcess : IProcess
    {
        private readonly Process _process;

        public SystemProcess(Process process)
        {
            _process = Guard.AgainstNull(process); 
        }

        public void Kill()
        {
            _process.Kill();
        }
    }
}