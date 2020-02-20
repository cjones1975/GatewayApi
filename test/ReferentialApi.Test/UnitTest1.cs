using System;
using Xunit;
using ReferentialApi.Controllers;

namespace ReferentialApi.Test
{
    public class UnitTest1
    {

        WeatherForecastController controller = new WeatherForecastController();
        [Fact]
        public void GetReturnName() {
            var returnValue = controller.Get(1);
            Assert.Equal("Warm and Sunny", returnValue.Value);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
