using Xunit;

namespace ProjectEuler.Tests
{
    public class NumberLetterCounts_Count_Test
    {
        [Theory]
        [InlineData(1, 3)]
        [InlineData(2, 6)]
        [InlineData(5, 19)]
        [InlineData(20, 112)]
        [InlineData(21, 121)]
        [InlineData(1000, 21124)]
        public void Count_GivenANumber_ReturnsNumberOfLetterUsedToWriteFromOneToThatNumber(
            int number,
            int expectedCount)
        {
            // arrange
            var sut = new NumberLetterCounts();

            // act
            var count = sut.Count(number);

            // assert
            Assert.Equal(expectedCount, count);
        }
    }
}