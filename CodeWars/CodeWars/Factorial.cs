using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
   /*
        In mathematics, the factorial of a non-negative integer n, denoted by n!, is the product of all positive integers less than or equal to n. For example: 5! = 5 * 4 * 3 * 2 * 1 = 120. By convention the value of 0! is 1.

        Write a function to calculate factorial for a given input. If input is below 0 or above 12 throw an exception of type ArgumentOutOfRangeException (C#) or IllegalArgumentException (Java) or throw a RangeError (JavaScript).

        More details about factorial can be found here: http://en.wikipedia.org/wiki/Factorial

    */
    class Factorial
    {
        public static int calculateFactorial(int n)
        {
            if (n > 12 || n < 0)
            {
                throw new ArgumentOutOfRangeException("input", "input must be between 0 and 12");
            }
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * calculateFactorial(n - 1);
            }
        }
    }
}
