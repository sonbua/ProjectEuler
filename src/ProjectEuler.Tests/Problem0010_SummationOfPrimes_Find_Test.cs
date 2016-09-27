using Xunit;

namespace ProjectEuler.Tests
{
    public class SummationOfPrimes_Find_Test
    {
        [Theory]
        [InlineData(2, 2)]
        [InlineData(3, 5)]
        [InlineData(5, 10)]
        [InlineData(10, 17)]
        [InlineData(15, 41)]
        public void GivenAnInclusiveUpper_ReturnsSumOfPrimesSmallerThanThat(int inclusiveUpper, long expectedSum)
        {
            // arrange
            var sut = new SummationOfPrimes();

            // act
            var sum = sut.Find(inclusiveUpper);

            // assert
            Assert.Equal(expectedSum, sum);
        }
    }
}