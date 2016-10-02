using Xunit;

namespace ProjectEuler.Tests
{
    public class LongestCollatzSequence_FindNumberWithLongestCollatzSequence_Test
    {
        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        [InlineData(3, 3)]
        [InlineData(13, 9)]
        public void GivenANumber_ReturnsNumberWithLongestCollatzSequence(int max, int expectedNumberWithLongestCollatzSequence)
        {
            // arrange
            var sut = new LongestCollatzSequence();

            // act
            var numberWithLongestCollatzSequence = sut.FindNumberWithLongestCollatzSequence(max);

            // assert
            Assert.Equal(expectedNumberWithLongestCollatzSequence, numberWithLongestCollatzSequence);
        }
    }
}