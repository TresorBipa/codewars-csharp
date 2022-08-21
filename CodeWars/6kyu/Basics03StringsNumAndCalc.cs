/*
https://www.codewars.com/kata/56b5dc75d362eac53d000bc8/csharp

6 kyu
Basics 03: Strings, Numbers and Calculation

Here you have to do some mathematical operations on a "dirty string". 
This kata checks some basics, it's not too difficult.

So what to do?

Input: String which consists of two positive numbers (doubles) and exactly one operator like +, -, * or / always between these numbers. 
The string is dirty, which means that there are different characters inside too, 
not only numbers and the operator. You have to combine all digits left and right, 
perhaps with "." inside (doubles), and to calculate the result which has to be rounded to an integer and converted to a string at the end.

Easy example:
Input: "gdfgdf234dg54gf*23oP42"
Output: "54929268" (because 23454*2342=54929268)
First there are some static tests, later on random tests too...

Hope you have fun! :-)
*/


using System;
using System.Data;
using System.Text.RegularExpressions;

namespace CodeWars;

public class Basics03StringsNumAndCalc
{
    public string calculateString(string calcIt)
    {
        return Convert.ToInt64(new DataTable().Compute(Regex.Replace(calcIt, @"[^\d*/+-.]+", ""), null)).ToString();

        // var s = Regex.Replace(calcIt, @"[^\d*/+-.]+", "");
        // return Convert.ToInt64(new DataTable().Compute(s, null)).ToString();
        // return Math.Round(Convert.ToDouble(new DataTable().Compute(s, null))).ToString();
    }
}

