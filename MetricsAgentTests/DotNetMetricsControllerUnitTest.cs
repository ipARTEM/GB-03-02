using MetricsAgent.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MetricsAgentTests
{
    public class DotNetMetricsControllerUnitTest
    {

        private DotNetMetricsController _controller;

        public DotNetMetricsControllerUnitTest()
        {
            _controller = new();
        }

        [Fact]
        public void GetMetrics_ReturnsOk()
        {
            //arrange     организовать 
           
            TimeSpan timeFrom = TimeSpan.FromSeconds(0);
            TimeSpan timeTo = TimeSpan.FromSeconds(100);

            //act        действие
            var result = _controller.GetMetric(timeFrom, timeTo);

            // assert     утверждать
            Assert.IsAssignableFrom<IAsyncResult>(result);


        }
    }
}
