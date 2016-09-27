using System.Linq;

namespace ProjectEuler
{
    /// <summary>
    /// Problem 6: Sum square difference
    /// https://projecteuler.net/problem=6
    /// 
    /// The sum of the squares of the first ten natural numbers is,
    /// 12 + 22 + ... + 102 = 385
    ///  The square of the sum of the first ten natural numbers is,
    /// (1 + 2 + ... + 10)2 = 552 = 3025
    ///  Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
    ///  Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
    /// </summary>
    public class SumSquareDifference
    {
        public int Find(int inclusiveUpperNumber)
        {
            if (inclusiveUpperNumber == 1)
                return 0;

            return Enumerable.Range(1, inclusiveUpperNumber - 1)
                             .SelectMany(i => Enumerable.Range(i + 1, inclusiveUpperNumber - i),
                                         (i, j) => i * j)
                             .Aggregate((seed, i) => seed + i) * 2;
        }
    }
}