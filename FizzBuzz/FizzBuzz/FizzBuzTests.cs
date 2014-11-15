using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FizzBuzz
{
    public class FizzBuzTests
    {
        [Fact]
        public void FizzBuzz_InitTest()
        {
            Assert.Equal(1, 1);
        }

        [Fact]
        public void FizzBuzz_IfOneReturnOne()
        {
            var number = 1;
            var game = new Game();

            var result = game.Play(number);

            Assert.Equal("1", result);
        }

        [Fact]
        public void ReturnFizzAsNumberDividedByThree()
        {
            var number = 12;
            var game = new Game();

            var result = game.Play(number);

            Assert.Equal("Fizz", result);
        
        }

        [Fact]
        public void ReturnBuzzAsNumberIsDividedByFive()
        {
            var number = 10;
            var game = new Game();

            var result = game.Play(number);

            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void ReturnFizzBuzzAsNumberIsDevidedByThreeAndFive()
        {
            var number = 30;
            var game = new Game();

            var result = game.Play(number);

            Assert.Equal("FizzBuzz", result);
        }

    }
}
