﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
    /// <summary>
    /// Problem 12: Highly divisible triangular number
    /// https://projecteuler.net/problem=12
    /// 
    /// The sequence of triangle numbers is generated by adding the natural numbers. So the 7th triangle number would be 1 + 2 + 3 + 4 + 5 + 6 + 7 = 28. The first ten terms would be:
    /// 1, 3, 6, 10, 15, 21, 28, 36, 45, 55, ...
    /// Let us list the factors of the first seven triangle numbers:
    ///      1: 1
    ///      3: 1,3
    ///      6: 1,2,3,6
    ///     10: 1,2,5,10
    ///     15: 1,3,5,15
    ///     21: 1,3,7,21
    ///     28: 1,2,4,7,14,28
    /// We can see that 28 is the first triangle number to have over five divisors.
    /// What is the value of the first triangle number to have over five hundred divisors?    
    /// </summary>
    public class HighlyDivisibleTriangularNumber
    {
        private readonly IList<TriangleNumber> _triangleNumbers = new List<TriangleNumber> {new TriangleNumber(0, 0)};

        public long Find(int numberOfDivisors)
        {
            while (_triangleNumbers.Last().NumberOfDivisors <= numberOfDivisors)
            {
                var nextTriangleOrder = _triangleNumbers.Last().Order + 1;
                var nextTriangleNumber = nextTriangleOrder.CalculateTriangleNumber();
                var triangleNumber = new TriangleNumber(nextTriangleOrder, FindDivisors(nextTriangleNumber).Count());
                _triangleNumbers.Add(triangleNumber);
            }

            return _triangleNumbers.Last().Order.CalculateTriangleNumber();
        }

        public IEnumerable<long> FindDivisors(long number)
        {
            if (number == 1)
            {
                yield return 1;
                yield break;
            }

            for (var i = 1; i <= Math.Sqrt(number); i++)
                if (number%i == 0)
                {
                    var j = number/i;
                    yield return i;
                    yield return j;
                }
        }

        private class TriangleNumber
        {
            public TriangleNumber(int order, int numberOfDivisors)
            {
                Order = order;
                NumberOfDivisors = numberOfDivisors;
            }

            public int Order { get; }

            public int NumberOfDivisors { get; }
        }
    }

    internal static class Int32Extensions
    {
        public static long CalculateTriangleNumber(this int order)
        {
            return (long) order*(order + 1)/2;
        }
    }
}