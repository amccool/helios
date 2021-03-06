using Helios.Net.Bootstrap;
using Helios.Topology;

namespace Helios.Reactor.Bootstrap
{
    /// <summary>
    /// Factory interface for creating new <see cref="IReactor"/> instances
    /// </summary>
    public interface IServerFactory : IConnectionFactory
    {
        IReactor NewReactor(INode listenAddress);
    }
}