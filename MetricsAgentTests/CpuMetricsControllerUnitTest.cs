using MetricsAgent.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MetricsAgentTests
{
    public class CpuMetricsControllerUnitTest
    {
        private CpuMetricsController _controller;

        public CpuMetricsControllerUnitTest()
        {
            _controller = new();
        }

        [Fact]
        public void GetMetricsFromAgent_ReturnsOk()
        {
            //arrange     организовать 
            int agentIdl = 1;
            TimeSpan timeFrom = TimeSpan.FromSeconds(0);
            TimeSpan timeTo = TimeSpan.FromSeconds(100);

            //act        действие
            var result = _controller.GetMetricsFromAgent( agentIdl, timeFrom, timeTo);

            // assert     утверждать
            Assert.IsAssignableFrom<IAsyncResult>(result);


        }


    }
}
