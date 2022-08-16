/*
https://www.codewars.com/kata/5b55c49d4a317adff500015f/csharp

6 kyu
Points in the circle

You have the radius of a circle with the center in point (0,0).

Write a function that calculates the number of points in the circle where (x,y) - the cartesian coordinates of the points - are integers.

Example: for radius = 2 the result should be 13.

0 <= radius <= 1000
*/


using System;

namespace CodeWars._6kyu;

/// <summary>
/// https://www.codewars.com/kata/5b55c49d4a317adff500015f/train/csharp
/// 6 kyu
/// Points in the circle
/// </summary>
public static class PointsInCircle
{
    public static int pointsNumber(int radius)
    {
        var count = 0;
        for (var x = 0; x <= radius; x++)
            count += (int) Math.Sqrt(radius * radius - x * x);
        return 4 * count + 1;
    }
}