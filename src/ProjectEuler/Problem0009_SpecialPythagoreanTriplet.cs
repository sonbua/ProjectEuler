using System;

namespace ProjectEuler
{
    /// <summary>
    /// Problem 9: Special Pythagorean triplet
    /// https://projecteuler.net/problem=9
    /// 
    /// A Pythagorean triplet is a set of three natural numbers, a &lt; b &lt; c, for which,
    /// a2 + b2 = c2
    /// For example, 32 + 42 = 9 + 16 = 25 = 52.
    /// There exists exactly one Pythagorean triplet for which a + b + c = 1000.
    /// Find the product abc.
    /// </summary>
    public class SpecialPythagoreanTriplet
    {
        public int FindProduct(int tripletSum)
        {
            for (var i = 1; i < tripletSum - 2; i++)
                for (var j = 1; j < tripletSum - i - 1; j++)
                {
                    var k = tripletSum - i - j;

                    if (i*i + j*j == k*k)
                        return i*j*k;
                }
            throw new NotSupportedException();
        }
    }
}