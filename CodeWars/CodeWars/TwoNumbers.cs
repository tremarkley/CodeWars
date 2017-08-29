using System;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    class TwoNumbers
    {
        int[] first = { 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 9 };
        
        int[] second = { 5, 6, 4, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 9, 9, 9, 9 };

        public TwoNumbers()
        {
            int first_count = first.Length;
            ListNode l1 = new ListNode(first[0]);
            ListNode l2 = new ListNode(second[0]);
            ListNode Next1 = null;
            ListNode Next2 = null;
            for (int i = 1; i < first.Length; i++)
            {
                if (l1.next != null)
                {
                    Next1.next = new ListNode(first[i]);
                    Next1 = Next1.next;
                }
                else
                {
                    l1.next = new ListNode(first[i]);
                    Next1 = l1.next;
                }
            }
            for(int i = 1; i < second.Length; i++)
            {
                if (l2.next != null)
                {
                    //ListNode Next = l2.next;
                    Next2.next = new ListNode(second[i]);
                    Next2 = Next2.next;
                }
                else
                {
                    l2.next = new ListNode(second[i]);
                    Next2 = l2.next;
                }
            }

            Solution Solution = new Solution();
            Solution.AddTwoNumbers(l1, l2);
           
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public class Solution
        {
            /*
                    You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order and each of their nodes contain a single digit. Add the two numbers and return it as a linked list.

                    You may assume the two numbers do not contain any leading zero, except the number 0 itself.

                    Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
                    Output: 7 -> 0 -> 8
             */
            public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
            {
                Stack<int> L1Stack = new Stack<int>();
                Stack<int> L2Stack = new Stack<int>();
                do
                {
                    L1Stack.Push(l1.val);
                    if (l1.next != null)
                    {
                        l1 = l1.next;
                    }
                    else
                    {
                        break;
                    }
                } while (true);
                do
                {
                    L2Stack.Push(l2.val);
                    if (l2.next != null)
                    {
                        l2 = l2.next;
                    }
                    else
                    {
                        break;
                    }
                } while (true);
                string L1_str = String.Empty;
                while (L1Stack.Count > 0)
                {
                    L1_str += L1Stack.Pop().ToString();
                }
                string L2_str = String.Empty;
                while (L2Stack.Count > 0)
                {
                    L2_str += L2Stack.Pop().ToString();
                }

                BigInteger L1_int = BigInteger.Parse(L1_str);
                BigInteger L2_int = BigInteger.Parse(L2_str);
                BigInteger sum = L1_int + L2_int;
                string sum_str = sum.ToString();
                char[] sum_char_arr = sum_str.ToCharArray();
                ListNode result = new ListNode(sum_char_arr[sum_char_arr.Length - 1] - '0');
                ListNode Next = null;
                int i = sum_char_arr.Length - 2;
                while (i >= 0)
                {
                    if (result.next != null)
                    {
                        //ListNode Next = result.next;
                        Next.next = new ListNode(sum_char_arr[i] - '0');
                        Next = Next.next;
                    }
                    else
                    {
                        result.next = new ListNode(sum_char_arr[i] - '0');
                        Next = result.next;
                    }
                    i--;
                }
                return result;
            }
        }
    }
}
