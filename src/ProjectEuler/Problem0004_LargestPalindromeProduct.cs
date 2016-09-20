using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
    /// <summary>
    /// Problem 4: Largest palindrome product
    /// https://projecteuler.net/problem=4
    /// 
    /// A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
    /// Find the largest palindrome made from the product of two 3-digit numbers.
    /// </summary>
    public class LargestPalindromeProduct
    {
        public int Find(int numberOfDigits)
        {
            var min = Convert.ToInt32(Math.Pow(10, numberOfDigits - 1));
            var max = Convert.ToInt32(Math.Pow(10, numberOfDigits) - 1);

            return FindAllPalindromeProducts(min, max).Max();
        }

        public bool IsPalindrome(int number)
        {
            var numberAsText = number.ToString();
            var length = numberAsText.Length;

            for (var i = 0; i <= length/2; i++)
                if (numberAsText[i] != numberAsText[length - 1 - i])
                    return false;

            return true;
        }

        private IEnumerable<int> FindAllPalindromeProducts(int min, int max)
        {
            var fullSequence = Enumerable.Range(min, max - min + 1).ToArray();

            return Enumerable.Range(min, max - min + 1)
                             .Where(x => x%11 == 0)
                             .SelectMany(x => fullSequence.Select(y => x*y))
                             .Where(IsPalindrome);
        }
    }
}