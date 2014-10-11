using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FizzBuzz
{
    
    public class Class1
    {

        [Fact]
        public void testMethod1()
        {
            Assert.Equal(true, true);
        }

        [Fact]
        public void TestSimpleInput()
        {
            Game fizz = new Game();
            Assert.Equal(fizz.play(1), 1);
        }

        [Fact]
        public void TestComplexInput()
        {
            Game fizz = new Game();
            Assert.Equal(fizz.play(3), 3);
        }

  


    }
}
