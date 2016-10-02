using Xunit;

namespace ProjectEuler.Tests
{
    public class LargeSum_FindFirstTenDigitsOfSum_Test
    {
        [Theory]
        [InlineData(new[]
                    {
                        "37107287533902102798797998220837590246510135740250"
                    }, 3710728753)]
        [InlineData(new[]
                    {
                        "37107287533902102798797998220837590246510135740250",
                        "46376937677490009712648124896970078050417018260538"
                    }, 8348422521)]
        [InlineData(new[]
                    {
                        "37107287533902102798797998220837590246510135740250",
                        "46376937677490009712648124896970078050417018260538",
                        "74324986199524741059474233309513058123726617309629"
                    }, 1578092114)]
        public void GivenAnArrayOfLargeNumbers_ReturnsSumOfFirstTenDigits(string[] numbers, long expectedSum)
        {
            // arrange
            var sut = new LargeSum();

            // act
            var sum = sut.FindFirstTenDigitsOfSum(numbers);

            // assert
            Assert.Equal(expectedSum, sum);
        }
    }
}