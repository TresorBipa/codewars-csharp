/*
https://www.codewars.com/kata/calculate-average/csharp
https://www.codewars.com/kata/57a2013acf1fa5bfc4000921/csharp

8 kyu
Calculate average

Write a function which calculates the average of the numbers in a given list.
Note: Empty arrays should return 0.
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class CalculateAverage
    {
        public static double FindAverage(double[] array)
        {
            return array.Length == 0 ? 0 : array.Average();
        }


        //public static Double FindAverage( Double[] array )
        //{
        //    if ( array == null )
        //        throw new ArgumentNullException( nameof( array ), "Array can not be null" );

        //    return array.Any() ? array.Average() : 0;
        //}


        //public static double FindAverage(double[] array) => array.DefaultIfEmpty().Average();
    }
}