/*
https://www.codewars.com/kata/59bd84b8a0640e7c49002398/csharp

7 kyu
Triangle area

Task.

Calculate area of given triangle. 
Create a function t_area that will take a string which will represent triangle, 
find area of the triangle, one space will be equal to one length unit. 
The smallest triangle will have one length unit.

Hints

Ignore dots.

Example:

.
.      .  
.      .       .      ---> should return 2.0

.
.      .  
.      .       .     
.      .       .      .      ---> should return 4.5
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class TriangleArea
    {
        public static double TArea(string s)
        {
            return Math.Pow(s.Split('\n').Length - 3, 2) / 2;
            // return Math.Pow(s.Count(c => c == '\n') - 2, 2) / 2.0;
            // return Math.Pow(s.Count(i => "\n".Contains(i)) - 2, 2) / 2;
        }
    }
}