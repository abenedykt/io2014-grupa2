using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Sdk;

namespace DiscountSystem.Tests
{
    public class OrderTests
    {
        [Fact]
        public void When_first_discount_is_added_discount_list_is_not_empty()
        {
            var order = new Order();
            var discount = new TestDiscount();

            order.AddDiscount(discount);
            var isDiscountAdded = order.Discounts.Any();

            Assert.Equal(true, isDiscountAdded);
        }

        [Fact]
        public void When_first_discount_is_added_it_is_located_on_first_position()
        {
            var order = new Order();
            var discount = new TestDiscount();

            order.AddDiscount(discount);
            var isFirst = order.Discounts.First().Equals(discount);

            Assert.Equal(true, isFirst);
        }

        [Fact]
        public void When_order_do_not_allow_for_discounts_it_throw_exception()
        {
            var order = new Order
            {
                CanAddDiscounts = false
            };
            var discount = new TestDiscount();

            Assert.Throws(typeof(Exception), () => { order.AddDiscount(discount); });
        }

        [Fact]
        public void When_discount_can_not_be_used_many_times_and_it_is_already_added_it_should_throw_exception()
        {
            var order = new Order();
            var discount = new TestDiscount()
            {
                CanBeUsedMultipleTimes = false
            };

            order.AddDiscount(discount);

            Assert.Throws<Exception>(() => { order.AddDiscount(discount); });
        }

        [Fact]
        public void When_discount_can_not_be_used_with_other_discounts_and_discount_are_added_it_should_throw_exception()
        {
            var order = new Order();
            var discount = new TestDiscount
            {
                CanBeUsedWithOtherDiscounts = false
            };

            order.AddDiscount(discount);

            Assert.Throws<Exception>(() => { order.AddDiscount(discount); });
        }

        [Fact]
        public void When_discount_allows_for_multiple_adding_and_can_be_used_with_other_discounts_it_should_not_throw_exception()
        {
            var order = new Order();
            var discount = new TestDiscount("First discount")
            {
                CanBeUsedMultipleTimes = true,
                CanBeUsedWithOtherDiscounts = true
            };
            var secondDiscount = new TestDiscount("SecondDiscount")
            {
                CanBeUsedMultipleTimes = true,
                CanBeUsedWithOtherDiscounts = true
            }; 

            order.AddDiscount(discount);

            Assert.DoesNotThrow(() => { order.AddDiscount(secondDiscount); });
        }

        [Fact]
        public void CanAddItemToOrder()
        {
            var order = new Order();
            var item1 = new Item();

            order.AddItem(item1);

            Assert.Equal(1, order.Items.Count());
        }

        private class TestDiscount : Discount
        {
            public TestDiscount(string name = "TestDiscount")
                : base(name)
            {

            }

            public override void ApplyDiscount()
            {
                throw new NotImplementedException();
            }
        }
    }
}
