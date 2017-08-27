using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\hmarkley\Documents\input.txt";
            string outputpath = @"C:\Users\hmarkley\Documents\RESULTSBALANCED1.txt";

            List<string> list = new List<string>();
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    list.Add(line); // Add to list.
                }
            }
            string[] input = new string[3];
            using (StreamWriter writer =
            new StreamWriter(outputpath))
            {
                foreach (string brackets in list)
                {
                    //writer.WriteLine(BalancedBrackets.isBalanced(brackets));
                    writer.WriteLine(BalancedBrackets.isBalancedStack(brackets));
                }
            }
            input[0] = "{[()]}";
            input[1] = "{[(])}";
            input[2] = "{{}(";
            string test2 = BalancedBrackets.isBalancedStack(input[2]);
            Console.ReadLine();
        }
    }
}
