using Xunit;

namespace ProjectEuler.Tests
{
    public class SumSquareDifference_Find_Test
    {
        [Theory]
        [InlineData(1, 0)]
        [InlineData(2, 4)]
        [InlineData(3, 22)]
        [InlineData(10, 2640)]
        public void GivenAnInclusiveUpper_ReturnsSumSquareDifference(int inclusiveUpperNumber, int expectedSumSquareDifference)
        {
            // arrange
            var sut = new SumSquareDifference();

            // act
            var sumSquareDifference = sut.Find(inclusiveUpperNumber);

            // assert
            Assert.Equal(expectedSumSquareDifference, sumSquareDifference);
        }
    }
}