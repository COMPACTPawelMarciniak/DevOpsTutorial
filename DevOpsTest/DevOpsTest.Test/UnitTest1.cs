using System;
using Xunit;
using DevOpsAPI.Controllers;

namespace DevOpsTest.Test
{
    public class UnitTest1
    {
        WeatherForecastController controller = new WeatherForecastController();
        [Fact]
        public void ReturnsMyName()
        {
            var returnValue = controller.GetTest();
            Assert.Equal("Paweł", returnValue);
        }



        [Fact]
        public void Test1()
        {

        }
    }
}
