using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
    /// <summary>
    /// Problem 17: Number letter counts
    /// https://projecteuler.net/problem=17
    /// 
    /// If the numbers 1 to 5 are written out in words: one, two, three, four, five, then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.
    /// If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, how many letters would be used?
    /// NOTE: Do not count spaces or hyphens. For example, 342 (three hundred and forty-two) contains 23 letters and 115 (one hundred and fifteen) contains 20 letters. The use of "and" when writing out numbers is in compliance with British usage.
    /// </summary>
    public class NumberLetterCounts
    {
        public int Count(int number)
        {
            var numberToWords = new NumberToWords();

            return
                Enumerable.Range(1, number)
                    .Select(x => numberToWords.Translate(x))
                    .Select(x => x.Replace(" ", string.Empty))
                    .SelectMany(x => x)
                    .Count();
        }
    }

    internal class NumberToWords
    {
        private readonly Dictionary<int, string> _baseMap = new Dictionary<int, string>
        {
            {0, string.Empty},
            {1, "one"},
            {2, "two"},
            {3, "three"},
            {4, "four"},
            {5, "five"},
            {6, "six"},
            {7, "seven"},
            {8, "eight"},
            {9, "nine"},
            {10, "ten"},
            {11, "eleven"},
            {12, "twelve"},
            {13, "thirteen"},
            {14, "fourteen"},
            {15, "fifteen"},
            {16, "sixteen"},
            {17, "seventeen"},
            {18, "eighteen"},
            {19, "nineteen"},
            {20, "twenty"},
            {30, "thirty"},
            {40, "forty"},
            {50, "fifty"},
            {60, "sixty"},
            {70, "seventy"},
            {80, "eighty"},
            {90, "ninety"},
        };

        private readonly List<UnitWordPair> _pairs = new List<UnitWordPair>
        {
            new UnitWordPair {Unit = 1000000000, Word = "billion"},
            new UnitWordPair {Unit = 1000000, Word = "million"},
            new UnitWordPair {Unit = 1000, Word = "thousand"},
            new UnitWordPair {Unit = 100, Word = "hundred"}
        };

        public string Translate(int number)
        {
            foreach (var pair in _pairs)
            {
                if (number >= pair.Unit)
                {
                    if (number % pair.Unit == 0)
                    {
                        return
                            string.Format(
                                "{0} {1}",
                                Translate(number / pair.Unit),
                                pair.Word
                            ).TrimEnd();
                    }

                    return
                        string.Format(
                            "{0} {1} and {2}",
                            Translate(number / pair.Unit),
                            pair.Word,
                            Translate(number % pair.Unit)
                        ).TrimEnd();
                }
            }

            if (number >= 21)
            {
                return
                    string.Format(
                        "{0} {1}",
                        _baseMap[number / 10 * 10],
                        Translate(number % 10)
                    ).TrimEnd();
            }

            return _baseMap[number];
        }
    }

    internal class UnitWordPair
    {
        public int Unit { get; set; }

        public string Word { get; set; }
    }
}