/*
https://www.codewars.com/kata/55eeddff3f64c954c2000059/csharp

6 kyu
Sum consecutives

You are given a list/array which contains only integers (positive and negative).
Your job is to sum only the numbers that are the same and consecutive. 
The result should be one list.

Extra credit if you solve it in one line.
You can assume there is never an empty list/array and there will always be an integer.

Same meaning: 1 == 1

1 != -1

#Examples:

[1,4,4,4,0,4,3,3,1] # should return [1,12,0,4,6,1]

"""So as you can see sum of consecutives 1 is 1 
sum of 3 consecutives 4 is 12 
sum of 0... and sum of 2 
consecutives 3 is 6 ..."""

[1,1,7,7,3] # should return [2,14,3]
[-5,-5,7,7,12,0] # should return [-10,14,12,0]
*/


using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class KataSumConsecutives
    {
        public static List<int> SumConsecutives(List<int> s)
        {
            var result = new List<int>();
            for (var i = 0; i < s.Count; i++)
            {
                var sum = s[i];
                while (i != s.Count - 1 && s[i] == s[i + 1])
                {
                    sum += s[++i];
                }

                result.Add(sum);
            }

            return result;

            // return Enumerable.Range(0, s.Count)
            //     .Where(i => i == 0 || s[i - 1] != s[i])
            //     .Select(i => new {Sum = s.Skip(i).TakeWhile(x => x == s[i]).Sum()})
            //     .Select(x => x.Sum)
            //     .ToList();
            //
            //
            // return s.Select((e, i) => (e, i)).Where(x => x.i == 0 || x.e != s[x.i - 1])
            //     .Select(x => s.Skip(x.i).TakeWhile(z => (z == x.e)).Sum())
            //     .ToList();
        }
    }
}