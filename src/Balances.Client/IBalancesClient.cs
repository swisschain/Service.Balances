using Balances.Client.Api;

namespace Balances.Client
{
    /// <summary>
    /// Balances service client.
    /// </summary>
    public interface IBalancesClient
    {
        /// <summary>
        /// Balances API.
        /// </summary>
        IBalancesApi Balances { get; }
    }
}
