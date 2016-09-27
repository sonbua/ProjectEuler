using Xunit;

namespace ProjectEuler.Tests
{
    public class SpecialPythagoreanTriplet_FindProduct_Test
    {
        [Theory]
        [InlineData(12, 60)]
        [InlineData(30, 780)]
        public void GivenSumOfPythagoreanTriplet_ReturnsProduct(int tripletSum, int expectedProduct)
        {
            // arrange
            var sut = new SpecialPythagoreanTriplet();

            // act
            var product = sut.FindProduct(tripletSum);

            // assert
            Assert.Equal(expectedProduct, product);
        }
    }
}