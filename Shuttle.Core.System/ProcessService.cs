using System.Diagnostics;

namespace Shuttle.Core.System
{
    public class ProcessService : IProcessService
    {
        public IProcess GetCurrentProcess()
        {
            return new SystemProcess(Process.GetCurrentProcess());
        }
    }
}