/*
https://www.codewars.com/kata/55606aeebf1f0305f900006f/csharp

7 kyu
Convert Integer to Binary

Convert integers to binary as simple as that. You would be given an integer as a argument and you have to return its binary form. 
To get an idea about how to convert a decimal number into a binary number, visit here.

Notes: negative numbers should be handled as two's complement; assume all numbers are integers stored using 4 bytes (or 32 bits) in any language.

Your output should ignore leading 0s.

So, for example:

Converter.ToBinary(3) == "11"
Converter.ToBinary(-3) == "11111111111111111111111111111101"
Be Ready for Large Numbers. Happy Coding ^_^
*/

using System;

namespace CodeWars
{
    public class ConvertIntegerToBinary
    {
        public static string ToBinary(int n)
        {
            return Convert.ToString(n, 2);
        }
    }
}