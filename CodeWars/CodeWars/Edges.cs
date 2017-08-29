using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    class Connections
    {
        /*
         Input contains two pairs of strings. Each string represents the name of a vertex. The value and key form an edge. 
         Goal is to find all vertices connected to one another.

             */
        public static List<List<string>> FindConnections(Dictionary<string, List<string>> Connections)
        {
            List<string> toDelete = new List<string>();
            foreach (KeyValuePair<string, List<string>> i in Connections)
            {
                
                foreach (string vertex in i.Value)
                if (Connections.ContainsKey(vertex))
                {
                        Connections[vertex].Add(i.Key);
                        foreach (string connection in Connections[i.Key])
                        {
                            if (connection != vertex)
                            {
                                Connections[vertex].Add(connection);
                            }
                        }
                        //remove this from dictionary since they have all been moved now
                        //Connections.Remove(i.Key);
                        toDelete.Add(i.Key);
                }
            }
            foreach (string delete in toDelete)
            {
                if (Connections.ContainsKey(delete))
                {
                    Connections.Remove(delete);
                }
            }
            List<List<string>> output = new List<List<string>>();
            foreach (KeyValuePair<string, List<string>> j in Connections)
            {
                List<string> inter = new List<string>();
                inter.Add(j.Key);
                foreach (string str in j.Value)
                {
                    inter.Add(str);
                }
                output.Add(inter);
            }

            return output;
        }
    }
}
