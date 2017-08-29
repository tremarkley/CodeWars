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
            /*string path = @"C:\Users\hmarkley\Documents\Algorithms\Connections.txt";
            string outputpath = @"C:\Users\hmarkley\Documents\Algorithms\Connections_Output.txt";

            Dictionary<string, List<string>> Connections = new Dictionary<string, List<string>>();
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] output = line.Split(' ');
                    if (!Connections.ContainsKey(output[0]))
                    {
                        Connections.Add(output[0], new List<string>() { output[1] });
                    }
                    else
                    {
                        Connections[output[0]].Add(output[1]);
                    }
                }
            }
            List<List<string>> testme = CodeWars.Connections.FindConnections(Connections);*/

            TwoNumbers TwoNumbers = new TwoNumbers();
            Console.ReadLine();
        }
    }
}
