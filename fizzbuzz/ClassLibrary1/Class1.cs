using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ClassLibrary1
{
    public class Class1
    {
        [Fact]
        public void test1()
        {
            Assert.Equal(true, true);
        }

        [Fact]
        public void daje_1_mam_1()
        {
            Game game = new Game();
            var result = game.play("1");
            Assert.Equal("1",result);
        }

        [Fact]
        public void sprawdz_3()
        {
            Game game = new Game();
            var result = game.play("3");
            Assert.Equal("fizz",result);

        }

        [Fact]
        public void sprawdz_5()
        {
            Game game = new Game();
            var result = game.play("5");
            Assert.Equal("buzz", result);
        }
    }
}
