/*
https://www.codewars.com/kata/559760bae64c31556c00006b/csharp

7 kyu
Number climber

For every positive integer N, there exists a unique sequence starting with 1 and ending with N and such that every number in the sequence is either the double of the preceeding number or the double plus 1.

For example, given N = 13, the sequence is [1, 3, 6, 13], because . . . :

 3 =  2*1 +1
 6 =  2*3
 13 = 2*6 +1

Write a function that returns this sequence given a number N. 
Try generating the elements of the resulting list in ascending order, i.e., 
without resorting to a list reversal or prependig the elements to a list.
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class NumberClimber
    {
        public static int[] Climb(int n)
        {
            return new int[(int) Math.Log(n, 2)].Select(_ => n /= 2).Prepend(n).Reverse().ToArray();
            //return new string(' ', (int) Math.Log(n, 2)).Select(_ => n /= 2).Prepend(n).Reverse().ToArray();
            //return Enumerable.Range(0, (int) Math.Log(n, 2)).Select(_ => n /= 2).Prepend(n).Reverse().ToArray();


            // var seq = new List<int> {n};
            // while (n > 1) seq.Insert(0, n /= 2);
            // return seq.ToArray();


            // List<int> seq = new List<int> {n};
            // while (n > 1)
            // {
            //     seq.Insert(0, n /= 2);
            // }
            // return seq.ToArray();


            // var numbers = new List<int> {n};
            // while (numbers.Min() > 1)
            // {
            //     numbers.Add(numbers.Last() / 2);
            // }
            // return numbers.ToArray().Reverse().ToArray();


            // List<int> lista = new List<int>();
            // while (n >= 1)
            // {
            //     lista.Insert(0, n);
            //     n /= 2;
            // }
            // return lista.ToArray();


            // var res = new List<int>();
            // do
            // {
            //     res.Add(n);
            //     n = n / 2;
            // } while (n > 0);
            // return res.Select(x => x).Reverse().ToArray();


            // var res = new List<int>() {n};
            // while (n > 1)
            // {
            //     n /= 2;
            //     res.Add(n);
            // }
            //
            // return res.OrderBy(e => e).ToArray();


            // var num = n;
            // var result = new List<int>();
            // while (num >= 1)
            // {
            //     result.Add(num);
            //     num /= 2;
            // }
            // return result.ToArray().Reverse().ToArray();


            // List<int> lst = new List<int>() {n};
            // while (n > 1) lst.Add((n /= 2));
            // lst.Sort();
            // return lst.ToArray();


            // List<int> sequence = new List<int> { n };
            // while(n != 1)
            // {
            //     n = n%2 == 0 ? n/2 : (n - 1)/2;
            //
            //     sequence.Add(n);
            // }
            // return sequence.OrderBy(e => e).ToArray();


            // var list = new List<int> {n};
            // while (n > 1)
            // {
            //     n = n / 2;
            //     list.Add(n);
            // }
            // return list.OrderBy(y => y).ToArray();


            // var result = new List<int>();
            // while (n >= 1)
            // {
            //     result.Add(n);
            //     n = n / 2;
            // }
            // result.Reverse();
            // return result.ToArray();


            // return Enumerable.Range(0, (int) Math.Log(n, 2) + 1)
            //     .Select(i => n / (int) Math.Pow(2, (int) Math.Log(n, 2) - i))
            //     .ToArray();


            // List<int> numbers = new List<int>();
            //
            // for (int i = n; i >= 1; i = i / 2)
            // {
            //     numbers.Insert(0, i);
            // }
            // return numbers.ToArray();


            // var result = new List<int> {n};
            // while (result.Last() > 1)
            // {
            //     result.Add(result.Last() / 2);
            // }
            // result.Reverse();
            // return result.ToArray();
        }
    }
}