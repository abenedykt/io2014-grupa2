using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FizzBuzz
{
    public class FizzBuzzTests
    {
        [Fact]
        public void FizzBuzz()
        {
            Assert.Equal(true, true);
        }

        [Fact]
        public void Play_Return1ForArgument1_1()
        {
            var game = new Game();

            var result = game.Play(1);

            Assert.Equal("1", result);
        }

        [Fact]
        public void Play_ReturnFizzForNumberDividedBy3_Fizz()
        {
            var game = new Game();

            var result = game.Play(6);

            Assert.Equal(result, "Fizz");
        }

        [Fact]
        public void Play_ReturnBuzzForNumberDividedBy5_Fizz()
        {
            var game = new Game();

            var result = game.Play(10);

            Assert.Equal(result, "Buzz");
        }

        [Fact]
        public void Play_ReturnFizzBuzzForNumberDividedBy3And5_FizzBuzz()
        {
            var game = new Game();

            var result = game.Play(15);

            Assert.Equal(result, "FizzBuzz");
        }
    }
}
