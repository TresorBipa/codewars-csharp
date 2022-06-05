/*
https://www.codewars.com/kata/5ce399e0047a45001c853c2b/csharp

6 kyu
Sums of Parts

Let us consider this example (array written in general format):

ls = [0, 1, 3, 6, 10]

Its following parts:

ls = [0, 1, 3, 6, 10]
ls = [1, 3, 6, 10]
ls = [3, 6, 10]
ls = [6, 10]
ls = [10]
ls = []
The corresponding sums are (put together in a list): [20, 20, 19, 16, 10, 0]

The function parts_sums (or its variants in other languages) will take as parameter a list ls and return a list of the sums of its parts as defined above.

Other Examples:
ls = [1, 2, 3, 4, 5, 6] 
parts_sums(ls) -> [21, 20, 18, 15, 11, 6, 0]

ls = [744125, 935, 407, 454, 430, 90, 144, 6710213, 889, 810, 2579358]
parts_sums(ls) -> [10037855, 9293730, 9292795, 9292388, 9291934, 9291504, 9291414, 9291270, 2581057, 2580168, 2579358, 0]
Notes
Take a look at performance: some lists have thousands of elements.
Please ask before translating.
*/

using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class SumsOfParts
    {
        public static int[] PartsSums(int[] ls)
        {
            // int sum = ls.Sum();
            // return ls.Select((x, i) => sum -= ls[i]).Prepend(sum).ToArray();

            // List<int> result = new List<int> {ls.Sum()};
            // foreach (var v in ls)
            // {
            //     result.Add(result.Last() - v);
            // }
            // return result.ToArray();


            // return ls.Aggregate(new[] {ls.Sum()}.AsEnumerable(), (c, n) => c.Prepend(c.First() - n)).Reverse().ToArray();
            // return ls.Reverse().Aggregate(Enumerable.Repeat(0, 1), (a, i) => a.Prepend(a.First() + i)).ToArray();


            int[] result = new int[ls.Length + 1];

            for (int i = ls.Length - 1; i >= 0; i--)
                result[i] = ls[i] + result[i + 1];

            return result;
        }
    }
}