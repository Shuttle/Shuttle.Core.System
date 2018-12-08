using Shuttle.Core.Container;
using Shuttle.Core.Contract;

namespace Shuttle.Core.System
{
    public class Bootstrap : IComponentRegistryBootstrap
    {
        public void Register(IComponentRegistry registry)
        {
            Guard.AgainstNull(registry, nameof(registry));

            registry.AttemptRegister<IEnvironmentService, EnvironmentService>();
            registry.AttemptRegister<IProcessService, ProcessService>();
        }
    }
}