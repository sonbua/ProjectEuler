using Xunit;

namespace ProjectEuler.Tests
{
    public class SmallestMultiple_Find_Test
    {
        [Theory]
        [InlineData(1, 3, 6)]
        [InlineData(1, 4, 12)]
        [InlineData(1, 6, 60)]
        [InlineData(1, 10, 2520)]
        public void GivenTwoNumber_ReturnsSmallestMultiple(int min, int max, int expectedSmallestMultiple)
        {
            // arrange
            var sut = new SmallestMultiple();

            // act
            var smallestMultiple = sut.Find(min, max);

            // assert
            Assert.Equal(expectedSmallestMultiple, smallestMultiple);
        }
    }
}