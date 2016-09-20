﻿using System.Linq;

namespace ProjectEuler
{
    public class MultiplesOf3And5
    {
        public int Sum(int upper)
        {
            return Enumerable.Range(0, upper)
                             .Where(x => x%3 == 0 || x%5 == 0)
                             .Sum();
        }
    }
}