using Xunit;

namespace ProjectEuler.Tests
{
    public class PowerDigitSumTest
    {
        [Theory]
        [InlineData(0, 1)]
        [InlineData(1, 2)]
        [InlineData(2, 4)]
        [InlineData(3, 8)]
        [InlineData(15, 26)]
        [InlineData(1000, 1366)]
        public void Sum_GivenAPower_ThenReturnsCorrectSumOfItsDigits(int power, int expectedSum)
        {
            // arrange
            var powerDigitSum = new PowerDigitSum();

            // act
            var sum = powerDigitSum.Sum(power);

            // assert
            Assert.Equal(expectedSum, sum);
        }
    }
}