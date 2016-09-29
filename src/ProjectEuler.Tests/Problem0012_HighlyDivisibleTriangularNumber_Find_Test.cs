using Xunit;

namespace ProjectEuler.Tests
{
    public class HighlyDivisibleTriangularNumber_Find_Test
    {
        [Theory]
        [InlineData(1, 3)]
        [InlineData(3, 6)]
        [InlineData(5, 28)]
        public void GivenANumberOfDivisors_ReturnsTheSmallestTriangleNumber(int numberOfDivisors, long expectedTriangleNumber)
        {
            // arrange
            var sut = new HighlyDivisibleTriangularNumber();

            // act
            var triangleNumber = sut.Find(numberOfDivisors);

            // assert
            Assert.Equal(expectedTriangleNumber, triangleNumber);
        }
    }
}