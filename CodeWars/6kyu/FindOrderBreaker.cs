/*
https://www.codewars.com/kata/5fc2a4b9bb2de30012c49609/csharp

6 kyu
Find the Order Breaker

In this kata, you have an integer array which was ordered by ascending except one number.

For Example: [1,2,3,4,17,5,6,7,8]
For Example: [19,27,33,34,112,578,116,170,800]
You need to figure out the first breaker. Breaker is the item, when removed from sequence, sequence becomes ordered by ascending.

For Example: [1,2,3,4,17,5,6,7,8] => 17 is the only breaker.

For Example: [19,27,33,34,112,578,116,170,800] => 578 is the only breaker.

For Example: [105, 110, 111, 112, 114, 113, 115] => 114 and 113 are breakers. 114 is the first breaker.
    When removed 114, sequence becomes ordered by ascending => [105, 110, 111, 112, 113, 115]
    When removed 113, sequence becomes ordered by ascending => [105, 110, 111, 112, 114, 115]

For Example: [1, 0, 2] => 1 and 0 are the breakers. 1 is the first breaker.
    When removed 1, sequence becomes ordered by ascending => [0, 2]
    When removed 0, sequence becomes ordered by ascending => [1, 2]
    
For Example: [1, 2, 0, 3, 4] => 0 is the only breaker.
    When removed 0, sequence becomes ordered by ascending. => [1, 2, 3, 4]
    
TASK:
Write a function that returns the first breaker.

Notes:

Input array does not contain any duplicate element.
*/


using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class FindOrderBreaker
    {
        public static int OrderBreaker(int[] input)
        {
            return input.First(x => input.Except(new[] {x}).SequenceEqual(input.Except(new[] {x}).OrderBy(i => i)));
            // return input.FirstOrDefault(i => input.Where(j => j != i).SequenceEqual(input.Where(k => k != i).OrderBy(x => x)));
            // return input.FirstOrDefault(i => input.Except(new[] {i}).SequenceEqual(input.Except(new[] {i}).OrderBy(x => x)));
            // return input.Select(i => new {i, arr = input.Except(new[] {i})}).First(x => x.arr.SequenceEqual(x.arr.OrderBy(i => i))).i;
            // return input.ToList().Find(m => input.Where(i => i != m).SequenceEqual(input.Where(i => i != m).OrderBy(x => x)));
            // return input.ToList().Find(m => input.Except(new[] {m}).SequenceEqual(input.Except(new[] {m}).OrderBy(x => x)));
        }
    }
}