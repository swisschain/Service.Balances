using System.Collections.Generic;
using Balances.Client.Models.IsAlive;
using Microsoft.AspNetCore.Mvc;
using Swisschain.Sdk.Server.Common;

namespace Balances.WebApi
{
    [ApiController]
    [Route("api/[controller]")]
    public class IsAliveController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var response = new IsAliveModel
            {
                Name = ApplicationInformation.AppName,
                Version = ApplicationInformation.AppVersion,
                StartedAt = ApplicationInformation.StartedAt,
                Env = ApplicationEnvironment.Environment,
                HostName = ApplicationEnvironment.HostName,
                StateIndicators = new List<IsAliveModel.StateIndicator>()
            };

            return Ok(response);
        }
    }
}
