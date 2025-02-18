﻿/*
https://www.codewars.com/kata/5bb804397274c772b40000ca/csharp

7 kyu
Stacked Balls - 2D

Background
I have stacked some pool balls in a triangle.

Like this,

pool balls
Kata Task
Given the number of layers of my stack, what is the total height?

Return the height as multiple of the ball diameter.

Example
The image above shows a stack of 5 layers.

Notes
layers >= 0
approximate answers (within 0.001) are good enough
See Also

Stacked Balls - 2D
Stacked Balls - 3D with square base
Stacked Balls - 3D with triangle base
*/

using System;

namespace CodeWars
{
    public class StackedBalls2D
    {
        public static double StackHeight2d(int layers)
        {
            return layers < 1 ? 0 : Math.Sqrt(3) / 2 * (layers - 1) + 1;
        }
    }
}