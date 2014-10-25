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
        public void Test()
        {
            Assert.Equal(true, true);
        }

        [Fact]
        public void Jezeli_1_zwroc_1()
        {
            Game game = new Game();
            var result = game.Play(1);

            Assert.Equal(result, "1");
        }

        [Fact]
        public void Jezeli_3_zwroc_Fizz()
        {
            Game game = new Game();
            var result = game.Play(3);

            Assert.Equal(result, "Fizz");
        }

        [Fact]
        public void Jezeli_5_zwroc_Fazz()
        {
            Game game = new Game();
            var result = game.Play(5);

            Assert.Equal(result, "Bazz");
        }

        [Fact]
        public void Jezeli_3i5_zwroc_FizzFazz()
        {
            Game game = new Game();
            var result = game.Play(15);

            Assert.Equal(result, "FizzBazz");
        }
    }
}
