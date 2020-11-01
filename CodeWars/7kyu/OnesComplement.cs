/*
https://www.codewars.com/kata/59b11f57f322e5da45000254/csharp

7 kyu
Ones' Complement

The Ones' Complement of a binary number is the number obtained by swapping all the 0s for 1s and all the 1s for 0s. For example:

onesComplement(1001) = 0110
onesComplement(1001) = 0110
For any given binary number,formatted as a string, return the Ones' Complement of that number.
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class KataOnesComplement
    {
        public static string OnesComplement(string n)
        {
            //return n.Replace('1', 'x').Replace('0', '1').Replace('x', '0');
            //return string.Concat(n.Select(x => x == '1' ? "0" : "1"));
            return string.Concat(n.Select(c => (char) (c ^ 1)));
        }
    }
}