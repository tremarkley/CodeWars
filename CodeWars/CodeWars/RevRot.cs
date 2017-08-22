using System;

namespace CodeWars
{
    public class Revrot
    {
        public static string RevRot(string strng, int sz)
        {
            if (String.IsNullOrEmpty(strng) || sz <= 0)
            {
                return "";
            }
            else if (sz > strng.Length)
            {
                return "";
            }
            else
            {
                int numberOfChunks = strng.Length / sz;
                string finalString = string.Empty;
                for (int i = 0; i < numberOfChunks; i++)
                {
                    int startingPosition = i * sz;
                    string substr = strng.Substring(startingPosition, sz);
                    double sumOfCubesofDigits = 0;
                    //for (int j = 0; j < substr.Length; j++)
                    foreach(char c in substr)
                    {
                        sumOfCubesofDigits += Math.Pow(int.Parse(c.ToString()), 3);
                    }
                    if (sumOfCubesofDigits % 2 == 0)
                    {
                        //reverse
                        char[] charArray = substr.ToCharArray();
                        Array.Reverse(charArray);
                        substr = new string(charArray);
                    }
                    else
                    {
                        string firstChar = substr.Substring(0, 1);
                        substr = substr.Substring(1) + firstChar;
                    }
                    finalString += substr;
                }
                return finalString;
            }
        }
    }
}
