using System.Linq;

namespace ProjectEuler
{
    /// <summary>
    /// Problem 16: Power digit sum
    /// https://projecteuler.net/problem=16
    /// 
    /// 2^15 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.
    /// What is the sum of the digits of the number 2^1000?
    /// </summary>
    public class PowerDigitSum
    {
        public int Sum(int power)
        {
            if (power == 0)
            {
                return 1;
            }

            var digits = new int[power];

            digits[0] = 1;

            for (var i = 1; i <= power; i++)
            {
                var addOneToNext = false;

                for (var position = 0; position < power; position++)
                {
                    var product = 2 * digits[position];

                    if (addOneToNext)
                    {
                        product++;
                    }

                    if (product < 10)
                    {
                        digits[position] = product;
                        addOneToNext = false;
                        continue;
                    }

                    digits[position] = product - 10;
                    addOneToNext = true;
                }
            }

            return digits.Sum();
        }
    }
}