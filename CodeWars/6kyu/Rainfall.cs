/*
https://www.codewars.com/kata/56a32dd6e4f4748cc3000006/csharp

6 kyu
Rainfall

dataand data1 are two strings with rainfall records of a few cities for months from January to December. 
The records of towns are separated by \n. The name of each town is followed by :.

data and towns can be seen in "Your Test Cases:".

Task:
function: mean(town, strng) should return the average of rainfall for the city town and the strng data or data1 (In R and Julia this function is called avg).
function: variance(town, strng) should return the variance of rainfall for the city town and the strng data or data1.
Examples:
mean("London", data), 51.19(9999999999996) 
variance("London", data), 57.42(833333333374)
Notes:
if functions mean or variance have as parameter town a city which has no records return -1 or -1.0 (depending on the language)
Don't truncate or round: the tests will pass if abs(your_result - test_result) <= 1e-2 or abs((your_result - test_result) / test_result) <= 1e-6 depending on the language.
Shell tests only variance
A ref: http://www.mathsisfun.com/data/standard-deviation.html
data and data1 (can be named d0 and d1 depending on the language; see "Sample Tests:") are adapted from: http://www.worldclimate.com
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public static class Rainfall
    {
        private static double[] GetData(string t, string s)
        {
            return s.Split("\n").FirstOrDefault(x => x.StartsWith($"{t}:"))?.Split(",")
                .Select(x => double.Parse(x.Split()[1])).ToArray();
        }

        public static double Mean(string t, string s)
        {
            return GetData(t, s)?.Average(x => x) ?? -1;
        }

        public static double Variance(string t, string s)
        {
            var mean = Mean(t, s);
            return GetData(t, s)?.Average(a => Math.Pow(a - mean, 2)) ?? -1;
        }
    }
}