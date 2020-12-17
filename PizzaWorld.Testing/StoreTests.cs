using PizzaWorld.Domain.Models;
using Xunit;

namespace PizzaWorld.Testing
{
    public class StoreTests
    {
        [Fact]
        private void Test_StoreExits()
        {
            var sut = new Store(); //type inference 
            Store sut2 = new Store(); //A statement, memory allocation

            //Act: Let's execute
            var actual = sut;

            //assert
            Assert.IsType<Store>(actual);
            Assert.NotNull(actual);

        }
    }
}