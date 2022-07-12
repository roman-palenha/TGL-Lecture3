using System;
using Xunit;

namespace TGL_Lecture3.Tests
{
    public class FactorialTests
    {
        [Theory]
        [InlineData(24, 4)]
        public void FindNormalNumberFactorial(int expected, int number)
        {
            Assert.Equal(expected, new Factorial().Find(number));
        }

        [Theory]
        [InlineData(-6)]
        public void FindNegativeNumberFactorial(int number)
        {
            Assert.Throws<ArgumentException>(() => new Factorial().Find(number));
        }
    }
}
