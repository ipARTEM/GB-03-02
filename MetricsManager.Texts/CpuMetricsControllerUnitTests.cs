using MetricsManager.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MetricsManager.Texts
{
    public class CpuMetricsControllerUnitTests
    {
        private CpuMetricsController _controller;

        public CpuMetricsControllerUnitTests()
        {
            _controller = new ();
        }

        [Fact]
        public void GetMetricsFromAgent_ReturnsOk()
        {
            //Arrange
            //var agentId = 1;
            var fromTime = TimeSpan.FromSeconds(0);
            var toTime = TimeSpan.FromSeconds(100);

            //Act
            var result = _controller.GetMetricsFromAgent(
                //agentId,
                fromTime, toTime);



            //Assert
            //Assert.Equal(result,10);

            Assert.IsAssignableFrom<IAsyncResult>(result);
        }
    }
}
