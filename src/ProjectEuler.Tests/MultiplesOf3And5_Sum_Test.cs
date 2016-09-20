using Xunit;

namespace ProjectEuler.Tests
{
    public class MultiplesOf3And5_Sum_Test
    {
        [Theory]
        [InlineData(3, 0)]
        [InlineData(4, 3)]
        [InlineData(6, 8)]
        [InlineData(10, 23)]
        [InlineData(20, 78)]
        public void Scenario_Result(int upper, int expected)
        {
            // arrange
            var sut = new MultiplesOf3And5();

            // act
            var sum = sut.Sum(upper);

            // assert
            Assert.Equal(expected, sum);
        }
    }
}