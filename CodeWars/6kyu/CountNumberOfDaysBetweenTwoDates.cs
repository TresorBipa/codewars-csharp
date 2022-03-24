/*
https://www.codewars.com/kata/59569ba543e2a8ebda00012a/

6 kyu
Count the number of days between two dates

Count the number of days between two dates:

Examples:
There are 5021 days between 1987.1.16 and 2000.10.15
Good Luck!
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace CodeWars
{
    public class CountNumberOfDaysBetweenTwoDates
    {
        public static long GetDaysAlive(int year, int month, int day, int year2, int month2, int day2)
        {
            return (long)(new DateTime(year2, month2, day2) - new DateTime(year, month, day)).TotalDays;
        }
    }
}