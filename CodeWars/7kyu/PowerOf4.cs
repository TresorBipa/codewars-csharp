/*
https://www.codewars.com/kata/544d114f84e41094a9000439/csharp

7 kyu
Power of 4

Write a method that returns true if a given parameter is a power of 4, and false if it's not. 
If parameter is not an Integer (eg String, Array) method should return false as well.

(In C# Integer means all integer Types like Int16,Int32,.....)

Examples
Power.PowerOf4(1024); // returns true
Power.PowerOf4(44); // returns false
Power.PowerOf4("not a positive integer"); // returns false
*/

using System;

namespace CodeWars
{
    public class KataPowerOf4
    {
        public static bool PowerOf4(object n)
        {
            // if (n == null || n is string || !long.TryParse(n.ToString(), out var number) || number < 4) return false;
            // return Math.Log(number, 4) % 1 == 0;

            return (n is long || n is int) && Convert.ToInt64(n) > 1 && Math.Log(Convert.ToInt64(n), 4) % 1 == 0;
        }
    }
}