using System;
using System.Linq;

namespace ProjectEuler
{
    /// <summary>
    /// Problem 10: Summation of primes
    /// https://projecteuler.net/problem=10
    /// 
    /// The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
    /// Find the sum of all the primes below two million.
    /// </summary>
    public class SummationOfPrimes
    {
        public long Find(int inclusiveUpper)
        {
            return Enumerable.Range(2, inclusiveUpper - 1)
                             .AsParallel()
                             .Where(number => Prime.IsPrime(number))
                             .Select(x => (long) x)
                             .Sum();
        }
    }
}