using Service.Balances.Protos;

namespace Balances.Client
{
    public interface IBalancesClient
    {
        Monitoring.MonitoringClient Monitoring { get; }
    }
}
