/*
https://www.codewars.com/kata/58417e9ab9c25c774500001f/csharp

6 kyu
Missing Angle

Below is a right-angled triangle:

  |\
  | \
  |  \
  |   \ 
o |    \ h 
  |     \
  |    θ \
  |_______\ 
     a

Your challange is to write a function (missingAngle in C/C#, missing_angle in Ruby), 
that calculates the angle θ in degrees to the nearest integer. 

You will be given three arguments representing each side: 
o, h and a. One of the arguments equals zero. Use the length of the two other sides to calculate θ. 

You will not be expected to handle any erronous data in your solution.
*/


using System;

namespace CodeWars;

public static class MissingAngle
{
    public static double missingAngle(double h, double a, double o)
    {
        var theta = h == 0 ? Math.Atan(o / a) : a == 0 ? Math.Asin(o / h) : Math.Acos(a / h);
        return Math.Round(theta * 180 / Math.PI);
    }
}

