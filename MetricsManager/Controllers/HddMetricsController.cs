using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetricsManager.Controllers
{
    [Route("api/metrics/hdd")]
    [ApiController]
    public class HddMetricsController : ControllerBase
    {
        [HttpGet("agent/{agentId}/{FreePhysicalMemory}")]
        public IActionResult GetFreeHddSize([FromRoute] int agentId, [FromRoute] int freefhysicalmemory)
        {
            return Ok();
        }
    }
}
