using System.Diagnostics;

namespace Shuttle.Platform;

public class ProcessService : IProcessService
{
    public IProcess GetCurrentProcess()
    {
        return new SystemProcess(Process.GetCurrentProcess());
    }
}