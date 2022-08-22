/*
https://www.codewars.com/kata/59c053f070a3b7d19100007e/csharp

6 kyu
Line Safari : Point distance from a line

Kata Task
Given 3 points a, b, c

            c
            
                     b         
  a

Find the shortest distance from point c to a straight line that passes through points a and b

Notes

all points are of the form [x,y] where x >= 0 and y >= 0
if a and b are the same then just return distance between a and c
use Euclidean distance
*/


using System;

namespace CodeWars;

public static class LineSafariPointDistanceFromLine
{
    public static double DistanceFromLine((int, int) a, (int, int) b, (int, int) c)
    {
        var (ax, ay) = a;
        var (bx, by) = b;
        var (cx, cy) = c;

        return a == b
            ? Math.Sqrt(Math.Pow(cx - ax, 2) + Math.Pow(cy - ay, 2))
            : Math.Abs((cx - ax) * (by - ay) - (cy - ay) * (bx - ax)) /
              Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2));
    }
}

