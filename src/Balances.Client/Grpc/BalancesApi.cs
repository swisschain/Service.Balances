using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Balances.Client.Api;
using Balances.Client.Models.Wallets;
using Grpc.Net.Client;
using Service.Balances.Contracts;

namespace Balances.Client.Grpc
{
    internal class BalancesApi : IBalancesApi
    {
        private readonly Service.Balances.Contracts.Balances.BalancesClient _client;

        public BalancesApi(string address)
        {
            var channel = GrpcChannel.ForAddress(address);
            _client = new Service.Balances.Contracts.Balances.BalancesClient(channel);
        }

        public async Task<IReadOnlyList<BalanceModel>> GetAllAsync(string walletId)
        {
            var response = await _client.GetAllAsync(new BalancesGetAllRequest {WalletId = walletId});

            return response.Balances
                .Select(balance => new BalanceModel(balance))
                .ToList();
        }

        public async Task<BalanceModel> GetByAssetIdAsync(string walletId, string assetId)
        {
            var response = await _client.GetByAssetIdAsync(
                new BalancesGetByAssetIdRequest {WalletId = walletId, AssetId = assetId});

            return response.Balance != null
                ? new BalanceModel(response.Balance)
                : null;
        }
    }
}
