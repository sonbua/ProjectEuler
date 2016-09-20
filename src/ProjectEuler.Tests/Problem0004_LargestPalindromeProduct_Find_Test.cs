using Xunit;

namespace ProjectEuler.Tests
{
    public class LargestPalindromeProduct_Find_Test
    {
        [Theory]
        [InlineData(2, 9009)]
        public void GivenADigitNumber_FindLargestPalindromeProduct(int numberOfDigits, int expectedLargestPalindromeProduct)
        {
            // arrange
            var sut = new LargestPalindromeProduct();

            // act
            var largestPalindromeProduct = sut.Find(numberOfDigits);

            // assert
            Assert.Equal(expectedLargestPalindromeProduct, largestPalindromeProduct);
        }
    }
}