using Xunit;

namespace ProjectEuler.Tests
{
    public class LargestProductInASeries_Find_Test
    {
        [Theory]
        [InlineData("12", 1, 2)]
        [InlineData("123", 1, 3)]
        [InlineData("123", 2, 6)]
        [InlineData("82166370484403199890008895243450658541227588666881", 4, 5832)]
        public void GivenANumberString_ReturnsLargestProductInASeries(string series, int sequenceLength, long expectedLargestProduct)
        {
            // arrange
            var sut = new LargestProductInASeries();

            // act
            var largestProduct = sut.Find(series, sequenceLength);

            // assert
            Assert.Equal(expectedLargestProduct, largestProduct);
        }
    }
}