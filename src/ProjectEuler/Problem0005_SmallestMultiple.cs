using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
    /// <summary>
    /// Problem 5: Smallest multiple
    /// https://projecteuler.net/problem=5
    /// 
    /// 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
    /// What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
    /// </summary>
    public class SmallestMultiple
    {
        public IEnumerable<int> FindPrimeFactors(int number)
        {
            if (number <= 3)
            {
                yield return number;
                yield break;
            }

            for (var i = 2; i <= Math.Sqrt(number);)
                if (number%i == 0)
                {
                    yield return i;
                    number /= i;
                }
                else
                    i++;

            yield return number;
        }

        public long Find(int min, int max)
        {
            return Enumerable.Range(min, max - min + 1)
                             .Select(FindPrimeFactors)
                             .SelectMany(factors => factors.GroupBy(x => x))
                             .GroupBy(g => g.Key)
                             .SelectMany(g => Enumerable.Repeat(g.Key, g.Max(x => x.Count())))
                             .Aggregate(1L, (seed, i) => seed*i);
        }
    }
}