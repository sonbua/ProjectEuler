using Xunit;

namespace ProjectEuler.Tests
{
    public class LargestPalindromeProduct_IsPalindrome_Test
    {
        [Theory]
        [InlineData(9009, true)]
        [InlineData(9008, false)]
        public void GivenANumber_SpecifiesWhetherItIsPalindrome(int number, bool expected)
        {
            // arrange
            var sut = new LargestPalindromeProduct();

            // act
            var isPalindrome = sut.IsPalindrome(number);

            // assert
            Assert.Equal(expected, isPalindrome);
        }
    }
}