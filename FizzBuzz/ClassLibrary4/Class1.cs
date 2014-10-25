using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ClassLibrary4
{
    public class Class1
    {
        [Fact]
        public void test1()
        {
            Assert.Equal(true, true);
        }

        [Fact]
        public void Sprawdzanie_dla_1()
        {
            Game game = new Game();
            var result = game.Play("1");
            Assert.Equal("1", result);
        }

        [Fact]
        public void Sprawdzanie_dla_3()
        {
            Game game = new Game();
            var result = game.Play("3");
            Assert.Equal("fizz", result);
        }

        [Fact]
        public void Sprawdzanie_dla_5()
        {
            Game game = new Game();
            var result = game.Play("5");
            Assert.Equal("buzz", result);
        }

    }
}
