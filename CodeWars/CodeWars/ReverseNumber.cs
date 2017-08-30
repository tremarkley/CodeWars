using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class ReverseNumber
    {
        /*
            Reverse digits of an integer.

            Example1: x = 123, return 321
            Example2: x = -123, return -321
         */
        public static int Reverse(int x)
        {
            bool isNegative;
            if (x < 0)
            {
                isNegative = true;
            }
            else
            {
                isNegative = false;
            }
            //int result = Math.Abs(x);
            int result = x;
            List<int> digits = new List<int>();
            do
            {
                if (result >= 10 || result <= -10)
                {
                    int digit = result % 10;
                    digits.Add(digit);
                }
                else
                {
                    digits.Add(result);
                    break;
                }
                result = result / 10;
            } while (true);
            string digit_str = String.Empty;
            foreach (int d in digits)
            {
                digit_str += Math.Abs(d).ToString();
            }
            try {
            //int final_result;
            result = Int32.Parse(digit_str);
            if (isNegative)
            {
                return result * -1;
            }
            else {
                return result;
            }
            //return result;
            }
            catch
            {
                return 0;
            }
        }
    }
}
