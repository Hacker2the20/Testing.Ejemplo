using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestingEjemploTests
{
    public class FactorialServiceTests
    {
        [Fact]
        public void TestFactorialZero()
        {
            FactorialService service = new FactorialService();

            int result  = service.Calculate(0);

            Assert.Equal(1, result);
        }

        [Fact]
        public void TestFatorialFive()
        {
            FactorialService service = new FactorialService();

            int result = service.Calculate(5);

            Assert.Equal(120, result);
        }
    }
}
