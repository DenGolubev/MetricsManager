using MetricsManager.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace MetricsManagerTests
{
    public class CpuByPercentileControllerUnitTest
    {
        private CpuMetricsController controller;
        public CpuByPercentileControllerUnitTest()
        {
            controller = new CpuMetricsController();
        }


        [Fact]
        public void GetMetricsFromAgent_ReturnsOk()
        {
            //Arrange
            var agentId = 1;
            var fromTime = TimeSpan.FromSeconds(0);
            var toTime = TimeSpan.FromSeconds(100);

            //Act
            var result = controller.GetMetricsByPercentileCPUFromAgent(agentId, fromTime, toTime);
            // Assert
            _ = Assert.IsAssignableFrom<IActionResult>(result);
            
        }
    }
}
