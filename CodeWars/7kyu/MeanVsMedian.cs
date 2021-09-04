/*
https://www.codewars.com/kata/5806445c3f1f9c2f72000031/csharp

7 kyu
Mean vs. Median

Your goal is to implement the method meanVsMedian which accepts an odd-length array of integers and returns one of the following:

'mean' - in case mean value is larger than median value
'median' - in case median value is larger than mean value
'same' - in case both mean and median share the same value
Reminder: Median

Array will always be valid (odd-length >= 3)
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class KataMeanVsMedian
    {
        public static string MeanVsMedian(int[] numbers)
        {
            return numbers.Average().CompareTo(numbers.OrderBy(x => x).ToArray()[numbers.Length / 2]) switch
            {
                1 => "mean",
                -1 => "median",
                _ => "same"
            };

            // double mean = numbers.Average();
            // //Array.Sort(numbers);
            // var median = numbers.OrderBy(x => x).ToArray()[numbers.Length / 2];
            //
            // return mean == median ? "same"
            //     : mean < median ? "median"
            //     : "mean";
        }
    }
}