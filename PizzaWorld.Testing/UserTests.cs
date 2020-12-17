using PizzaWorld.Domain.Models;
using Xunit;

namespace PizzaWorld.Testing
{
    public class UserTests
    {
        [Fact]
        private void Test_UserExits()
        {
            var sut = new User(); //type inference 
            User sut2 = new User(); //A statement, memory allocation

            //Act: Let's execute
            var actual = sut;

            //assert
            Assert.IsType<User>(actual);
            Assert.NotNull(actual);

        }
    }
}