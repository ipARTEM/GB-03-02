using MetricsManager.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MetricsManagerTests
{
    public class NetworkMetricsControllerUnitTest
    {

        private NetworkMetricsController _controller;

        public NetworkMetricsControllerUnitTest()
        {
            _controller = new();
        }

        [Fact]
        public void GetMetricsFromAgent_ReturnsOk()
        {
            //arrange     
            int agentIdl = 1;
            TimeSpan timeFrom = TimeSpan.FromSeconds(0);
            TimeSpan timeTo = TimeSpan.FromSeconds(100);

            //act      
            var result = _controller.GetMetricsFromAgent(agentIdl, timeFrom, timeTo);

            // assert    
            Assert.IsAssignableFrom<IAsyncResult>(result);

        }

        [Fact]
        public void GetMetricsFromAllCluster_ReturnsOk()
        {
            //arrange   
            TimeSpan timeFrom = TimeSpan.FromSeconds(0);
            TimeSpan timeTo = TimeSpan.FromSeconds(10);

            //act      
            var result = _controller.GetMetricsFromAllCluster( timeFrom, timeTo);

            // assert    
            Assert.IsAssignableFrom<IAsyncResult>(result);

        }


    }
}
