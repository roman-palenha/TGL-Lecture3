using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace TGL_Lecture3.Tests
{
    public class FibonacciTests
    {
        [Theory]
        [InlineData(new int[] { 0, 1, 1, 2, 3, 5 }, 5)]
        public void MakeNormalFibonacciSequence(int[] expected, int degree)
        {
            Assert.Equal(expected, new FibonacciSequence().Make(degree).ToArray());
        }

        [Theory]
        [InlineData(new int[] { 0 }, 0)]
        public void FibonacciSequenceForZeroDegree(int[] expected, int degree)
        {
            Assert.Equal(expected, new FibonacciSequence().Make(degree).ToArray());
        }


        [Theory]
        [InlineData(-6)]
        public void NegativeDegreeFibonacci(int degree)
        {
            Assert.Throws<ArgumentException>(() => new FibonacciSequence().Make(degree));
        }
    }
}
