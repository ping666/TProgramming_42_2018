using System;
using Xunit;
using CourseApp;

namespace test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            City ivanovo = new City();
            var res_country = ivanovo.Country;
            var res_population = ivanovo.Population ;
            var res_name = ivanovo.Name;
            Assert.Equal("Россия", res_country);
            Assert.Equal(316, res_population);
            Assert.Equal("Иваново", res_name);
        }
    }
}
