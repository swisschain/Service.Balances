using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Balances.Domain.Services;
using Grpc.Core;
using Service.Balances.Contracts;

namespace Balances.GrpcServices
{
    public class BalancesService : Service.Balances.Contracts.Balances.BalancesBase
    {
        private readonly IBalancesService _balancesService;
        private readonly IMapper _mapper;

        public BalancesService(IBalancesService balancesService, IMapper mapper)
        {
            _balancesService = balancesService;
            _mapper = mapper;
        }

        public override async Task<BalancesGetAllResponse> GetAll(BalancesGetAllRequest request,
            ServerCallContext context)
        {
            var balances = await _balancesService.GetAllAsync(request.WalletId);

            var response = new BalancesGetAllResponse();

            response.Balances.AddRange(_mapper.Map<List<Balance>>(balances));

            return response;
        }

        public override async Task<BalancesGetByAssetIdResponse> GetByAssetId(BalancesGetByAssetIdRequest request,
            ServerCallContext context)
        {
            var balance = await _balancesService.GetByAssetIdAsync(request.WalletId, request.AssetId);

            var response = new BalancesGetByAssetIdResponse {Balance = _mapper.Map<Balance>(balance)};

            return response;
        }
    }
}
