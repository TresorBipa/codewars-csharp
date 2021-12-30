/*
https://www.codewars.com/kata/5a1a9e5032b8b98477000004/csharp

7 kyu
Evens times last

Given a sequence of integers, return the sum of all the integers that have an even index (odd index in COBOL), multiplied by the integer at the last index.

Indices in sequence start from 0.

If the sequence is empty, you should return 0.
*/

using System.Linq;

namespace CodeWars
{
    public static class EvensTimesLast
    {
        public static int EvenTimesLast(int[] arr)
        {
            return arr.Where((_, i) => i % 2 == 0).Sum(x => x * arr[^1]);
            // return arr.Select((x, i) => i % 2 == 0 ? x * arr[^1] : 0).Sum();
            // return arr.Where((_,i) => i % 2 == 0).Sum() * arr.LastOrDefault();
            // return arr.Select((x, i) => i % 2 == 0 ? x : 0).Sum(x => x * arr[^1]);
            // return arr.Any() ? arr.Where((x,i) => i % 2 == 0).Sum() * arr[^1] : 0;
            // return arr.Where((_,i) => i % 2 == 0).Sum(x => x * arr.LastOrDefault());
        }
    }
}