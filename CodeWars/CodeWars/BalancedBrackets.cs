using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    /*
         A bracket is considered to be any one of the following characters: (, ), {, }, [, or ].

        Two brackets are considered to be a matched pair if the an opening bracket (i.e., (, [, or {) occurs to the left of a closing bracket (i.e., ), ], or }) of the exact same type. There are three types of matched pairs of brackets: [], {}, and ().

        A matching pair of brackets is not balanced if the set of brackets it encloses are not matched. For example, {[(])} is not balanced because the contents in between { and } are not balanced. The pair of square brackets encloses a single, unbalanced opening bracket, (, and the pair of parentheses encloses a single, unbalanced closing square bracket, ].

        By this logic, we say a sequence of brackets is considered to be balanced if the following conditions are met:

        It contains no unmatched brackets.
        The subset of brackets enclosed within the confines of a matched pair of brackets is also a matched pair of brackets.
        Given  strings of brackets, determine whether each sequence of brackets is balanced. If a string is balanced, print YES on a new line; otherwise, print NO on a new line.
    */
    class BalancedBrackets
    {
        //solved recursively
        public static string isBalanced(string s)
        {
            Dictionary<char, char> ClosingBracket = new Dictionary<char, char>()
            {
                {'{', '}'},
                {'(', ')'},
                {'[', ']'}
            };
            char[] values = s.ToCharArray();
            //trying to find a match for this bracket
            char initialBracket = values[0];
            string Result = "NO";
            //check to make sure initial bracket is not a closing bracket
            if (ClosingBracket.ContainsKey(initialBracket))
            {
                //count of the same initial bracket encountered
                int count = 0;
                //count of the closing brackets found
                int closingCount = 0;
                for (int j = 0; j < values.Length; j++)
                {
                    //check if this matches the initial bracket
                    if (initialBracket == values[j] && j != 0)
                    {
                        count += 1;
                    }
                    if (values[j] == ClosingBracket[initialBracket])
                    {
                        closingCount += 1;
                        //check how many closing brackets we have encountered against how many opening brackets there have been. 
                        if ((closingCount - 1) == count)
                        {
                            //reset counts once we find the matching ending
                            closingCount = 0;
                            count = 0;
                            //this means that there is an even number of brackets in between the match
                            if (j % 2 != 0)
                            {
                                //if the closing bracket is found right after the opening bracket then it is balanced
                                if (j == 1)
                                {
                                    Result = "YES";
                                }
                                //if there are chars between the opening and closing brackets then check that those are balanced as well
                                else if (j > 1)
                                {
                                    List<char> betweenChars = new List<char>();
                                    for (int t = 1; t < j; t++)
                                    {
                                        betweenChars.Add(values[t]);
                                    }
                                    string betweenCharsArr = string.Join("", betweenChars.ToArray());
                                    Result = isBalanced(betweenCharsArr);
                                    if (Result == "NO")
                                    {
                                        return Result;
                                    }
                                }
                                //if there are still more chars after we find the matching bracket check those seperately
                                if ((j + 1) < values.Length)
                                {
                                    List<char> remainingChars = new List<char>();
                                    for (int k = (j + 1); k < values.Length; k++)
                                    {
                                        remainingChars.Add(values[k]);
                                    }
                                    string remainingCharsArr = string.Join("", remainingChars.ToArray());
                                    Result = isBalanced(remainingCharsArr);
                                    if (Result == "NO")
                                    {
                                        return Result;
                                    }
                                }
                                
                            }
                            //there is not an even number of chars between the opening and closing bracket, therefore it cannot be balanced
                            else if (j == (values.Length - 1))
                            {
                                return Result = "NO";
                            }
                        }
                    }
                }
            }
            //the initial bracket is a closing bracket, therefore this cannot be balanced
            else
            {
                return Result = "NO";
            }

            return Result;
        }

        //solved using stack
        public static string isBalancedStack(string s)
        {
            string Result = "NO";
            Stack<char> Stack = new Stack<char>();
            Dictionary<char, char> ClosingBracket = new Dictionary<char, char>()
            {
                {'{', '}'},
                {'(', ')'},
                {'[', ']'}
            };
            char[] values = s.ToCharArray();
            for (int i = 0; i < values.Length; i++)
            {
                if (ClosingBracket.ContainsKey(values[i]))
                {
                    Stack.Push(ClosingBracket[values[i]]);
                }
                //as soon as you encounter a closing bracket check to make sure there is stuff in the stack and that the first value entered into the stack is equal to the closing bracket
                else if (Stack.Count > 0 && Stack.Pop() == values[i])
                {
                     Result = "YES";
                }
                else
                {
                    return Result = "NO";
                }
            }
            if (Stack.Count == 0)
            {
                Result = "YES"; 
            }
            else
            {
                Result = "NO";
            }
            return Result;
            
        }
    }
}
