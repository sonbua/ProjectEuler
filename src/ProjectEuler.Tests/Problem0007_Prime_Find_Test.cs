using Xunit;

namespace ProjectEuler.Tests
{
    public class Prime_Find_Test
    {
        [Theory]
        [InlineData(1, 2)]
        [InlineData(2, 3)]
        [InlineData(3, 5)]
        [InlineData(4, 7)]
        [InlineData(5, 11)]
        [InlineData(6, 13)]
        public void GivenANumber_ReturnsPrimeOfThatOrder(int order, long expectedPrime)
        {
            // arrange
            var sut = new Prime();

            // act
            var prime = sut.Find(order);

            // assert
            Assert.Equal(expectedPrime, prime);
        }
    }
}