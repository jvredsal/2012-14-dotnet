using PizzaWorld.Domain.Models;
using Xunit;

namespace PizzaWorld.Testing
{
    public class OrderTests
    {
        [Fact]
        private void Test_OrderExits()
        {
            var sut = new Order(); //type inference 
            Order sut2 = new Order(); //A statement, memory allocation

            //Act: Let's execute
            var actual = sut;

            //assert
            Assert.IsType<Order>(actual);
            Assert.NotNull(actual);

        }
    }
}