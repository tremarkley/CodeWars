using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = new string[3];
            input[0] = "{[()]}";
            input[1] = "{[(])}";
            input[2] = "{(([[(())]]})}{[]}";
            string test2 = BalancedBrackets.isBalanced(input[2]);
            Console.ReadLine();
        }
    }
}
