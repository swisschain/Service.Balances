using System.Collections.Generic;
using System.Threading.Tasks;
using Balances.Client.Models.Wallets;

namespace Balances.Client.Api
{
    /// <summary>
    /// Provides methods for work with balances API.
    /// </summary>
    public interface IBalancesApi
    {
        /// <summary>
        /// Returns all balances.
        /// </summary>
        /// <param name="walletId">The wallet identifier.</param>
        /// <returns>A collection of balances.</returns>
        Task<IReadOnlyList<BalanceModel>> GetAllAsync(string walletId);

        /// <summary>
        /// Returns all balances.
        /// </summary>
        /// <param name="walletId">The wallet identifier.</param>
        /// <param name="assetId">The asset identifier.</param>
        /// <returns>The asset balance.</returns>
        Task<BalanceModel> GetByAssetIdAsync(string walletId, string assetId);
    }
}
