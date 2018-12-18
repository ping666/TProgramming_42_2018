using System;
using CourseApp;
using Xunit;

namespace Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            City ivanovo = new City();
            var rescountry = ivanovo.Country;
            var respopulation = ivanovo.Population;
            var resname = ivanovo.Name;
            Assert.Equal("������", rescountry);
            Assert.Equal(316, respopulation);
            Assert.Equal("�������", resname);
        }

        [Fact]
        public void Test2()
        {
            City moscow = new City("������", "������");
            var rescountry = moscow.Country;
            var respopulation = moscow.Population;
            var resname = moscow.Name;
            Assert.Equal("������", rescountry);
            Assert.Equal(11000, respopulation);
            Assert.Equal("������", resname);
        }

        [Fact]
        public void Test3()
        {
            City spb = new City("�����", "������", 9000);
            var rescountry = spb.Country;
            var respopulation = spb.Population;
            var resname = spb.Name;
            Assert.Equal("������", rescountry);
            Assert.Equal(9000, respopulation);
            Assert.Equal("�����", resname);
        }

             [Fact]
        public void Test4()
        {
            var res = Program.Formula(0.1, 0.5, 0.15);
            Assert.Equal(0.001, res, 3);
        }

        [Fact]
        public void Test5()
        {
            var res = Program.Formula(0.0, 0.0, 0.1);
            Assert.Equal(0.0, res, 3);
        }
    }
}
