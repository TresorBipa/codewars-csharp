/*
https://www.codewars.com/kata/5a58ca28e626c55ae000018a/csharp

6 kyu
Calculate the area of a regular n sides polygon inside a circle of radius r

Write the following function:

public static double AreaOfPolygonInsideCircle(double circleRadius, int numberOfSides)
It should calculate the area of a regular polygon of numberOfSides, number-of-sides, 
or number_of_sides sides inside a circle of radius circleRadius, circle-radius, 
or circle_radius which passes through all the vertices of the polygon (such circle is called circumscribed circle or circumcircle). 
The answer should be a number rounded to 3 decimal places.

Input :: Output Examples
AreaOfPolygonInsideCircle(3, 3) // returns 11.691
AreaOfPolygonInsideCircle(5.8, 7) // returns 92.053
AreaOfPolygonInsideCircle(4, 5) // returns 38.042

*/

using System;

namespace CodeWars._6kyu
{
    public static class KataAreaOfPolygonInsideCircle
    {
        public static double AreaOfPolygonInsideCircle(double circleRadius, int numberOfSides)
        {
            return Math.Round(numberOfSides * circleRadius * circleRadius / 2 * Math.Sin(2 * Math.PI / numberOfSides),
                3);
        }
    }
}