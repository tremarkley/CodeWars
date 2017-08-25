using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    /* 
        Write simple .camelCase method (camel_case function in PHP or CamelCase in C#) for strings. All words must have their first letter capitalized without spaces.

        For instance:

        "hello case".camelCase() => HelloCase
        "camel case word".camelCase() => CamelCaseWord
         
    */
    public static class camelCase
    {
        public static string CamelCase(this string str)
        {
            string[] stringArr = str.Split(' ');
            for (int i = 0; i < stringArr.Length; i++)
            {
                if (stringArr[i].Length > 1)
                {
                    stringArr[i] = stringArr[i].Substring(0, 1).ToUpper() + stringArr[i].Substring(1).ToLower();
                }
                else
                {
                    stringArr[i] = stringArr[i].ToUpper();
                }
            }
            return string.Join("", stringArr);
        }
    }
}
