using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
    /// <summary>
    /// Problem 14: Longest Collatz sequence
    /// https://projecteuler.net/problem=14
    /// 
    /// The following iterative sequence is defined for the set of positive integers:
    /// n → n/2 (n is even)
    /// n → 3n + 1 (n is odd)
    /// Using the rule above and starting with 13, we generate the following sequence:
    /// 13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
    /// It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.
    /// Which starting number, under one million, produces the longest chain?
    /// NOTE: Once the chain starts the terms are allowed to go above one million.
    /// </summary>
    public class LongestCollatzSequence
    {
        public int FindNumberWithLongestCollatzSequence(int max)
        {
            return Enumerable.Range(1, max)
                             .AsParallel()
                             .Select(number => new
                                               {
                                                   Number = number,
                                                   CollatzSequenceLength = FindCollatzSequenceImpl(number).Count()
                                               })
                             .OrderBy(x => x.CollatzSequenceLength)
                             .Last()
                             .Number;
        }

        public long[] FindCollatzSequence(int number)
        {
            return FindCollatzSequenceImpl(number).ToArray();
        }

        private static IEnumerable<long> FindCollatzSequenceImpl(int number)
        {
            var numberLong = Convert.ToInt64(number);

            do
            {
                yield return numberLong;

                if (numberLong%2 == 0)
                    numberLong /= 2;
                else
                    numberLong = 3*numberLong + 1;
            }
            while (numberLong != 1);

            yield return 1;
        }
    }
}