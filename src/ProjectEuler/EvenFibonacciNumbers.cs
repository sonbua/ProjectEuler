using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
    public class EvenFibonacciNumbers
    {
        private readonly IList<int> _fibonacciList = new List<int> {1, 2};

        public int SumOfEvenNumbers(int inclusiveUpper)
        {
            return FindFibonacciSequence(inclusiveUpper).Where(x => x%2 == 0).Sum();
        }

        public IEnumerable<int> FindFibonacciSequence(int inclusiveUpper)
        {
            if (inclusiveUpper <= 2)
                return _fibonacciList.Take(inclusiveUpper);

            while (_fibonacciList.Last() < inclusiveUpper)
            {
                var nextFibonacciNumber = _fibonacciList[_fibonacciList.Count - 2] + _fibonacciList.Last();
                _fibonacciList.Add(nextFibonacciNumber);
            }

            return _fibonacciList.Where(x => x <= inclusiveUpper);
        }
    }
}