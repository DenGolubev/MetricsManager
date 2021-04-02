using Microsoft.AspNetCore.Mvc;
using System;

namespace MetricsManager.Controllers
{
    [Route("api/metrics/cpu")]
    [ApiController]

    public class CpuMetricsController : ControllerBase
    {
        [HttpGet("agent/{agentId}/from/{fromTime}/to/{toTime}")]
        public IActionResult GetMetricsCPUFromAgent([FromRoute] int agentId, [FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime)
        {
            return Ok();
        }

        [HttpGet("agent/{agentId}/from/{fromTime}/to/{toTime}/percentiles/{percentile}")]
        public IActionResult GetMetricsByPercentileCPUFromAgent([FromRoute] int agentId, [FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime)
        {
            return Ok();
        }
     }
}
