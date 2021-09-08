/*
https://www.codewars.com/kata/5b2a10fe9e40b9b43d00008c/csharp

7 kyu
Months, Weeks, Days, Hours and Minutes

Given a number of minutes, translate it into a readible human timestamp.
For example: 100 minutes equals "1 hour 40 minutes" And: 52874 minutes equals "1 month 1 week 1 day 17 hours 14 minutes"
Given that each month has 28 days.
The largest amount of minutes you'll have to test for is under a year so you'll have to translate it to Months, Weeks, Days, Hours and Minutes.
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class MonthsWeeksDaysHoursAndMinutes
    {
        public static string DisplayValue(int value)
        {
            // return string.Join(" ", new[]
            // {
            //     $"{value / 60 / 24 / 7 / 4 | 0} month",
            //     $"{value / 60 / 24 / 7 % 4 | 0} week",
            //     $"{value / 60 / 24 % 7 | 0} day",
            //     $"{value / 60 % 24 | 0} hour",
            //     $"{value % 60} minute"
            // }.Where(x => x[0] != '0').Select(x => int.Parse(x[..x.IndexOf(' ')]) > 1 ? x + 's' : x));


            // return string.Join(" ", new[]
            // {
            //     new {value = value / 60 / 24 / 7 / 4 | 0, text = " month"},
            //     new {value = value / 60 / 24 / 7 % 4 | 0, text = " week"},
            //     new {value = value / 60 / 24 % 7 | 0, text = " day"},
            //     new {value = value / 60 % 24 | 0, text = " hour"},
            //     new {value = value % 60, text = " minute"},
            // }.Where(x => x.value > 0).Select(x => x.value > 1 ? x.value + x.text + 's' : x.value + x.text));


            // return string.Join(" ", new Dictionary<string, int>
            // {
            //     {" month", value / 60 / 24 / 7 / 4 | 0},
            //     {" week", value / 60 / 24 / 7 % 4 | 0},
            //     {" day", value / 60 / 24 % 7 | 0},
            //     {" hour", value / 60 % 24 | 0},
            //     {" minute", value % 60},
            // }.Where(x => x.Value > 0).Select(x => x.Value > 1 ? x.Value + x.Key + 's' : x.Value + x.Key));


            // return string.Join(" ", new Dictionary<string, int>
            // {
            //     {" month", value / 60 / 24 / 7 / 4 | 0},
            //     {" week", value / 60 / 24 / 7 % 4 | 0},
            //     {" day", value / 60 / 24 % 7 | 0},
            //     {" hour", value / 60 % 24 | 0},
            //     {" minute", value % 60},
            // }.Where(x => x.Value > 0).Select(x => x.Value + x.Key + (x.Value > 1 ? "s" : "")));


            return string.Join(" ", new Dictionary<string, int>
            {
                {"month", value / 60 / 24 / 7 / 4 | 0},
                {"week", value / 60 / 24 / 7 % 4 | 0},
                {"day", value / 60 / 24 % 7 | 0},
                {"hour", value / 60 % 24 | 0},
                {"minute", value % 60},
            }.Where(x => x.Value > 0).Select(x => $"{x.Value} {x.Key}{(x.Value > 1 ? "s" : "")}"));
        }
    }
}