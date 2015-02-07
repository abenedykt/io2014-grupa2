using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DiscountSystem.Tests
{
    public class PercentageDiscountTests
    {
        [Fact]
        public void When_discount_value_is_higher_than_100_it_throw_exception()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var discount = new PercentageDiscount("TestDiscount", 110);
            });
        }

        [Fact]
        public void When_discount_value_is_less_than_0_it_throw_exception()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var discount = new PercentageDiscount("TestDiscount", -1);
            });
        }

        [Fact]
        public void CanAddValidDiscountValue()
        {
            Assert.DoesNotThrow(() =>
            {
                var discount = new PercentageDiscount("TestDiscount", 10);
            });
        }
    }
}
