/*
https://www.codewars.com/kata/588f5a38ec641b411200005b

7 kyu
Difference between years. (Level 1)

Write a function that receives two strings as parameter. 
This strings are in the following format of date: YYYY/MM/DD. 
Your job is: Take the years and calculate the difference between them.

Examples:
'1997/10/10' and '2015/10/10' -> 2015 - 1997 = returns 18 
'2015/10/10' and '1997/10/10' -> 2015 - 1997 = returns 18
At this level, you don't need validate months and days to calculate the difference.
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Data;

namespace CodeWars
{
    public class DifferenceBetweenYearsLevel1
    {
        public static int HowManyYears(string date1, string date2)
        {
            return Math.Abs(DateTime.Parse(date1).Year - DateTime.Parse(date2).Year);


            // var d1 = DateTime.Parse(date1).Year;
            // var d2 = DateTime.Parse(date2).Year;
            // if (d1 > d2)
            // {
            //     return d1 - d2;
            // }
            //
            // return d2 - d1;
        }
    }
}


