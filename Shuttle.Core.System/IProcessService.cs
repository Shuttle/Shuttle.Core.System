using System.Diagnostics;

namespace Shuttle.Core.System
{
    public interface IProcessService
    {
        Process GetCurrentProcess();
    }
}