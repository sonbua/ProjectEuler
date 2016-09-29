using System.Linq;
using Xunit;

namespace ProjectEuler.Tests
{
    public class HighlyDivisibleTriangularNumber_FindDivisors_Test
    {
        [Theory]
        [InlineData(1, new long[] {1})]
        [InlineData(3, new long[] {1, 3})]
        [InlineData(6, new long[] {1, 2, 3, 6})]
        public void GivenANumber_ReturnsTheDivisors(long number, long[] expectedDivisors)
        {
            // arrange
            var sut = new HighlyDivisibleTriangularNumber();

            // act
            var divisors = sut.FindDivisors(number).OrderBy(x => x);

            // assert
            Assert.True(expectedDivisors.OrderBy(x => x).SequenceEqual(divisors));
        }
    }
}