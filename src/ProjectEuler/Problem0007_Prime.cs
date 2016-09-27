using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
    /// <summary>
    /// Problem 7: 10001st prime
    /// https://projecteuler.net/problem=7
    /// 
    /// By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
    /// What is the 10 001st prime number?
    /// </summary>
    public class Prime
    {
        private static readonly IList<long> _primes = new List<long> {2};

        private static long NextPrime
        {
            get
            {
                var number = _primes.Last() + 1;

                while (!IsPrime(number))
                    number++;

                return number;
            }
        }

        public long Find(int order)
        {
            if (order <= _primes.Count)
                return _primes.ElementAt(order - 1);

            while (_primes.Count < order)
                _primes.Add(NextPrime);

            return _primes.Last();
        }

        private static bool IsPrime(long number)
        {
            for (var i = 2L; i <= Math.Sqrt(number); i++)
                if (number%i == 0)
                    return false;
            return true;
        }
    }
}