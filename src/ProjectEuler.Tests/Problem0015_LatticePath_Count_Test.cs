using Xunit;

namespace ProjectEuler.Tests
{
    public class LatticePath_Count_Test
    {
        [Theory]
        [InlineData(1, 2)]
        [InlineData(2, 6)]
        [InlineData(3, 20)]
        public void GivenAGridSize_ReturnsCorrectPathCount(int gridSize, long expectedPathCount)
        {
            // arrange
            var sut = new LatticePath();

            // act
            var pathCount = sut.Count(gridSize);

            // assert
            Assert.Equal(expectedPathCount, pathCount);
        }
    }
}