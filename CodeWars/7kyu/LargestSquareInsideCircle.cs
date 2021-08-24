/*
https://www.codewars.com/kata/5887a6fe0cfe64850800161c/csharp

7 kyu
Largest Square Inside A Circle

Determine the area of the largest square that can fit inside a circle with radius r.
*/

using System;

namespace CodeWars
{
    public class LargestSquareInsideCircle
    {
        public class Circle
        {
            public double AreaLargestSquare(int r)
            {
                return Math.Pow(2.0 * r, 2) / 2.0;
            }
        }

        public double AreaLargestSquare(int r)
        {
            return r * r * 2;
            //return Math.Pow(r, 2) * 2;
        }
    }
}