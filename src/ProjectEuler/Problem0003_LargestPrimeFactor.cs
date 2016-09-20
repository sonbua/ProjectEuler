using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
    /// <summary>
    /// Problem 3: Largest prime factor
    /// https://projecteuler.net/problem=3
    /// 
    /// The prime factors of 13195 are 5, 7, 13 and 29.
    /// What is the largest prime factor of the number 600851475143 ?
    /// </summary>
    public class LargestPrimeFactor
    {
        public long Find(long number)
        {
            return YieldFactors(number).Last();
        }

        private IEnumerable<long> YieldFactors(long number)
        {
            if (number <= 3)
            {
                yield return number;
                yield break;
            }

            for (var factor = 2; factor <= Math.Sqrt(number);)
            {
                if (number%factor == 0)
                {
                    yield return factor;
                    number /= factor;
                    continue;
                }
                factor++;
            }

            yield return number;
        }
    }
}