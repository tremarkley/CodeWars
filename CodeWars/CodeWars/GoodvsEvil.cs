using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class GoodvsEvil
    {
        public static string GoodVsEvil(string good, string evil)
        {
            Dictionary<int, int> GoodDictionary = new Dictionary<int, int>()
            {
                { 0, 1 },
                { 1, 2 },
                { 2, 3 },
                { 3, 3 },
                { 4, 4 },
                { 5, 10 }
            };

            Dictionary<int, int> EvilDictionary = new Dictionary<int, int>()
            {
                { 0, 1 },
                { 1, 2 },
                { 2, 2 },
                { 3, 2 },
                { 4, 3 },
                { 5, 5 },
                { 6, 10 }
            };

            int[] goodArray = good.Split(' ').Select(str => int.Parse(str)).ToArray();
            int[] evilArray = evil.Split(' ').Select(str => int.Parse(str)).ToArray();

            int goodTotal = 0;
            int evilTotal = 0;
            for (int i = 0; i < goodArray.Length; i++)
            {
                goodTotal += goodArray[i] * GoodDictionary[i];
            }
            for (int i=0; i < evilArray.Length; i++)
            {
                evilTotal += evilArray[i] * EvilDictionary[i];
            }

            if (goodTotal < evilTotal)
            {
                return "Battle Result: Evil eradicates all trace of Good";
            }
            else if (goodTotal > evilTotal)
            {
                return "Battle Result: Good triumphs over Evil";
            }
            else
            {
                return "Battle Result: No victor on this battle field";
            }
        }
    }
}
