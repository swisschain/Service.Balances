using System;
using Balances.Client.Api;
using Balances.Client.Grpc;

namespace Balances.Client
{
    /// <inheritdoc />
    public class BalancesClient : IBalancesClient
    {
        /// <summary>
        /// Initializes a new instance of <see cref="BalancesClient"/>.
        /// </summary>
        /// <param name="settings">The client settings.</param>
        public BalancesClient(BalancesClientSettings settings)
        {
            AppContext.SetSwitch("System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);

            Balances = new BalancesApi(settings.ServiceAddress);
        }

        /// <inheritdoc />
        public IBalancesApi Balances { get; }
    }
}
