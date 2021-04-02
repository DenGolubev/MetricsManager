using Microsoft.AspNetCore.Mvc;
using System;
using System.Management;

namespace MetricsManager.Controllers
{
    [Route("api/metrics/ram")]
    [ApiController]
    public class RamMetricsController : ControllerBase
    {
        [HttpGet("agent/{FreePhysicalMemory}")]

        public IActionResult GetTotalMemory ([FromRoute] int freefhysicalmemory)
        {
            return Ok();
        }
    }
}
