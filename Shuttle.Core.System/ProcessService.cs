using System.Diagnostics;

namespace Shuttle.Core.System
{
    public class ProcessService : IProcessService
    {
        public Process GetCurrentProcess()
        {
            return Process.GetCurrentProcess();
        }
    }
}