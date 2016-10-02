using System.Linq;
using Xunit;

namespace ProjectEuler.Tests
{
    public class LongestCollatzSequence_FindCollatzSequence_Test
    {
        [Theory]
        [InlineData(1, new long[] {1, 4, 2, 1})]
        [InlineData(2, new long[] {2, 1})]
        [InlineData(3, new long[] {3, 10, 5, 16, 8, 4, 2, 1})]
        [InlineData(9, new long[] {9, 28, 14, 7, 22, 11, 34, 17, 52, 26, 13, 40, 20, 10, 5, 16, 8, 4, 2, 1})]
        public void GivenANumber_ReturnsCollatzSequence(int number, long[] expectedCollatzSequence)
        {
            // arrange
            var sut = new LongestCollatzSequence();

            // act
            var sequence = sut.FindCollatzSequence(number);

            // assert
            Assert.True(sequence.SequenceEqual(expectedCollatzSequence));
        }
    }
}