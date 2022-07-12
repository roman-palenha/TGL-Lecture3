using System;
using System.Linq;

namespace TGL_Lecture3
{
    public class Factorial
    {
        public int Find(int number)
        {
            if (number <= 0)
                throw new ArgumentException("Wrong argument, must be > 0");
            return Enumerable.Range(1, number).Aggregate((x, y) => x * y);
        }
    }
}
