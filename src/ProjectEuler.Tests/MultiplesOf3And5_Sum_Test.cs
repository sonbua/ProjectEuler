using Xunit;

namespace ProjectEuler.Tests
{
    public class MultiplesOf3And5_Sum_Test
    {
        [Theory]
        [InlineData(3, 0)]
        [InlineData(4, 3)]
        [InlineData(6, 8)]
        [InlineData(10, 23)]
        [InlineData(20, 78)]
        public void GivenAUpperNumber_ReturnsCorrectSum(int upper, int expectedSum)
        {
            // arrange
            var sut = new MultiplesOf3And5();

            // act
            var sum = sut.Sum(upper);

            // assert
            Assert.Equal(expectedSum, sum);
        }
    }
}