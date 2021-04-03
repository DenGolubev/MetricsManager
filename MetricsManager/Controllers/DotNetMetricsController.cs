using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetricsManager.Controllers
{
    [Route("api/metrics/dotnet")]
    [ApiController]
    public class DotNetMetricsController : ControllerBase
    {
        public IActionResult GetMetricsDotNetFromAgent(TimeSpan fromTime, TimeSpan toTime)
        {
            return Ok();
        }
    }
}
