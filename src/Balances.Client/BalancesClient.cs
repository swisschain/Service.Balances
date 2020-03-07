using Balances.Client.Common;
using Service.Balances.Protos;

namespace Balances.Client
{
    public class BalancesClient : BaseGrpcClient, IBalancesClient
    {
        public BalancesClient(string serverGrpcUrl) : base(serverGrpcUrl)
        {
            Monitoring = new Monitoring.MonitoringClient(Channel);
        }

        public Monitoring.MonitoringClient Monitoring { get; }
    }
}
