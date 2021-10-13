/*
https://www.codewars.com/kata/sum-of-positive/csharp
https://www.codewars.com/kata/5715eaedb436cf5606000381/csharp

8 kyu
Sum of positive

You get an array of numbers, return the sum of all of the positives ones.

Example [1,-4,7,12] => 1 + 7 + 12 = 20

Note: if there is nothing to sum, the sum is default to 0.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWars
{
    public class PositiveSum
    {
        public static int positiveSum(int[] arr)
        {
            return arr.Where(n => n > 0).Sum();
        }

        //public static int PositiveSum(int[] arr)
        //{
        //    return arr.Sum(c => (c < 0 ? 0 : c));
        //}


    }
}
