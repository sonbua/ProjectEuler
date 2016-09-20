using Xunit;

namespace ProjectEuler.Tests
{
    public class LargestPrimeFactor_Find_Test
    {
        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 3)]
        [InlineData(4, 2)]
        [InlineData(5, 5)]
        [InlineData(6, 3)]
        [InlineData(8, 2)]
        [InlineData(10, 5)]
        [InlineData(13195, 29)]
        public void GivenANumber_ReturnsCorrectLargestPrimeFactor(long number, long expectedLargestPrimeFactor)
        {
            // arrange
            var sut = new LargestPrimeFactor();

            // act
            var largestPrimeFactor = sut.Find(number);

            // assert
            Assert.Equal(expectedLargestPrimeFactor, largestPrimeFactor);
        }
    }
}