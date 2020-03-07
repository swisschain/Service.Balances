using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Balances.Client.Models.Wallets;
using Balances.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace Balances.WebApi
{
    [ApiController]
    [Route("api/[controller]")]
    public class WalletsController : ControllerBase
    {
        private readonly IBalancesService _balancesService;
        private readonly IMapper _mapper;

        public WalletsController(IBalancesService balancesService, IMapper mapper)
        {
            _balancesService = balancesService;
            _mapper = mapper;
        }

        [HttpGet("{walletId}")]
        public async Task<IActionResult> GetAllAsync(string walletId)
        {
            var balances = await _balancesService.GetAllAsync(walletId);

            var model = _mapper.Map<List<BalanceModel>>(balances);

            return Ok(model);
        }

        [HttpGet("{walletId}/assets/{assetId}")]
        public async Task<IActionResult> GetByAssetIdAsync(string walletId, string assetId)
        {
            var balance = await _balancesService.GetByAssetIdAsync(walletId, assetId);

            var model = _mapper.Map<BalanceModel>(balance);

            return Ok(model);
        }
    }
}
