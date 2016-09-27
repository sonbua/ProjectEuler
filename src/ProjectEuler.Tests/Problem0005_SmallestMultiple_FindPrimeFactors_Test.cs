using System.Linq;
using Xunit;

namespace ProjectEuler.Tests
{
    public class SmallestMultiple_FindPrimeFactors_Test
    {
        [Theory]
        [InlineData(2, new[] {2})]
        [InlineData(3, new[] {3})]
        [InlineData(4, new[] {2, 2})]
        [InlineData(5, new[] {5})]
        [InlineData(6, new[] {2, 3})]
        [InlineData(8, new[] {2, 2, 2})]
        public void GivenANumber_ReturnsPrimeFactors(int number, int[] expectedPrimeFactors)
        {
            // arrange
            var sut = new SmallestMultiple();

            // act
            var enumerable = sut.FindPrimeFactors(number).ToArray();

            // assert
            Assert.True(enumerable.SequenceEqual(expectedPrimeFactors), string.Join(", ", enumerable));
        }
    }
}