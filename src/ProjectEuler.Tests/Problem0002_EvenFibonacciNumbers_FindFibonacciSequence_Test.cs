using System.Linq;
using Xunit;

namespace ProjectEuler.Tests
{
    public class EvenFibonacciNumbers_FindFibonacciSequence_Test
    {
        [Theory]
        [InlineData(-1, new int[] {})]
        [InlineData(0, new int[] {})]
        [InlineData(1, new[] {1})]
        [InlineData(2, new[] {1, 2})]
        [InlineData(3, new[] {1, 2, 3})]
        [InlineData(8, new[] {1, 2, 3, 5, 8})]
        [InlineData(89, new[] {1, 2, 3, 5, 8, 13, 21, 34, 55, 89})]
        public void GivenAnInclusiveUpperNumber_ReturnsCorrectFibonacciSequence(int inclusiveUpper, int[] expectedSequence)
        {
            // arrange
            var sut = new EvenFibonacciNumbers();

            // act
            var sequence = sut.FindFibonacciSequence(inclusiveUpper);

            // assert
            Assert.Equal(expectedSequence, sequence);
        }
    }
}