using System.Collections.Generic;
using System.Threading.Tasks;
using Balances.Domain.Entities;

namespace Balances.Domain.Services
{
    public interface IBalancesService
    {
        Task<IReadOnlyList<Balance>> GetAllAsync(string walletId);

        Task<Balance> GetByAssetIdAsync(string walletId, string assetId);
    }
}
