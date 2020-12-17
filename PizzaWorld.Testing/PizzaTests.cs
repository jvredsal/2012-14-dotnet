using PizzaWorld.Domain.Models;
using Xunit;

namespace PizzaWorld.Testing
{
    public class PizzaTests
    {
        [Fact]
        private void Test_PizzaExits()
        {
            var sut = new Pizza(); //type inference 
            Pizza sut2 = new Pizza(); //A statement, memory allocation

            //Act: Let's execute
            var actual = sut;

            //assert
            Assert.IsType<Pizza>(actual);
            Assert.NotNull(actual);

        }
    }
}