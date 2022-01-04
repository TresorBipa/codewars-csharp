/*
https://www.codewars.com/kata/5420fc9bb5b2c7fd57000004/csharp

6 kyu
Highest Rank Number in an Array

Complete the method which returns the number which is most frequent in the given input array. 
If there is a tie for most frequent number, return the largest number among them.

Note: no empty arrays will be given.

Examples
[12, 10, 8, 12, 7, 6, 4, 10, 12]              -->  12
[12, 10, 8, 12, 7, 6, 4, 10, 12, 10]          -->  12
[12, 10, 8, 8, 3, 3, 3, 3, 2, 4, 10, 12, 10]  -->   3
*/


using System;
using System.Linq;

namespace CodeWars
{
    public static class HighestRankNumberInArray
    {
        public static int HighestRank(int[] arr)
        {
            return arr.GroupBy(x => x).Max(g => (g.Count(), g.Key)).Key;
            // return arr.GroupBy(x => x).OrderBy(x => x.Count()).ThenBy(x => x.Key).Last().Key;
            // return arr.GroupBy(x => x).OrderBy(x => x.Count()).ThenBy(x => x.Key).First().Key;
            // return arr.GroupBy(x => x).OrderByDescending(x => x.Count()).ThenByDescending(x => x.Key).First().Key;
        }
    }
}