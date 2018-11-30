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
        [Fact]
        public void Test2()
        {
            City moscow = new City("Москва","Россия");
            var res_country = moscow.Country;
            var res_population = moscow.Population;
            var res_name = moscow.Name;
            Assert.Equal("Россия", res_country);
            Assert.Equal(11000, res_population);
            Assert.Equal("Москва", res_name);
        }
        [Fact]
        public void Test3()
        {
            City spb = new City("Питер", "Россия", 9000);
            var res_country = spb.Country;
            var res_population = spb.Population;
            var res_name = spb.Name;
            Assert.Equal("Россия", res_country);
            Assert.Equal(9000, res_population);
            Assert.Equal("Питер", res_name);
        }
             [Fact]
        public void Test4()
        {
            var res = Program.formula(0.1, 0.5, 0.15);
            Assert.Equal(0.001, res, 3);
        }
        [Fact]
        public void Test5()
        {
            var res = Program.formula(0.0, 0.0, 0.1);
            Assert.Equal(0.0, res, 3);
        }
    }
}
