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
        public void FirstTest()
        {
            Assert.Equal(true, true);
        }

        [Fact]
        public void Check_one_in_FizzBuzz()
        {
            Game game = new Game();
            var result = game.Play(1);
            Assert.Equal(result, "1");
        }

        [Fact]
        public void Check_tree_in_FizzBuzz()
        {
            Game game = new Game();
            var result = game.Play(3);            
            Assert.Equal(result, "Fizz");
        }

        [Fact]
        public void Check_five_in_FizzBuzz()
        {
            Game game = new Game();
            var result = game.Play(5);
            Assert.Equal(result, "Buzz");
        }

        [Fact]
        public void Check_tree_and_five_in_FizzBuzz()
        {
            Game game = new Game();
            var result = game.Play(15);
            Assert.Equal(result, "FizzBuzz");
        }
    }

}
