﻿using Xunit;

namespace ProjectEuler.Tests
{
    public class EvenFibonacciNumbers_SumOfEvenNumbers_Test
    {
        // 1, 2, 3, 5, 8, 13, 21, 34, 55, 89,...
        [Theory]
        [InlineData(1, 0)]
        [InlineData(2, 2)]
        [InlineData(5, 2)]
        [InlineData(89, 44)]
        public void GivenAnInclusiveUpperNumber_ReturnsCorrectSumOfEvenNumbers(int inclusiveUpper, int expectedSum)
        {
            // arrange
            var sut = new EvenFibonacciNumbers();

            // act
            var sumOfEvenNumbers = sut.SumOfEvenNumbers(inclusiveUpper);

            // assert
            Assert.Equal(expectedSum, sumOfEvenNumbers);
        }
    }
}