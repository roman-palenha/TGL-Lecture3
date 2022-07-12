using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TGL_Lecture3
{
    public class FibonacciSequence
    {
        public IEnumerable<int> Make(int degree)
        {
            if (degree < 0)
                throw new ArgumentException("Wrond degree");
            int prev = 0, current = 1, result;
            return Enumerable.Range(0, degree + 1).Select(x =>
            {
                if (x <= 1)
                {
                    return x;
                }
                else
                {
                    result = prev + current;
                    prev = current;
                    current = result;
                    return result;
                }
            });

        }
    }
}
