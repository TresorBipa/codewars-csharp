/*
https://www.codewars.com/kata/5641d9d4aceb8e30dc0000aa/csharp

7 kyu
Stick to The Screen Sides

Suppose there is a computer screen. When you move the cursor, and it gets close to the sides of the screen, the cursor will stick to them.

You have to implement a function which receives:

the screen dimensions
the sticky area width (a.k.a. "margin")
the current position of the cursor
and returns the new position of the cursor after it was possibly stuck to the screen side(s).

Note: if the mouse is outside the screen dimensions, return [0, 0] instead.
*/

namespace CodeWars
{
    public class StickToScreenSides
    {
        public static double[] newCoordinate(int w, int h, double margin, double[] coordinate)
        {
            double x = coordinate[0];
            double y = coordinate[1];

            return x > w | y > h | x < 0 | y < 0
                ? new double[] {0, 0}
                : new[]
                {
                    x <= margin ? 0 : x >= w - margin ? w : x,
                    y <= margin ? 0 : y >= h - margin ? h : y
                };

            // double x = coordinate[0];
            // double y = coordinate[1];
            //
            // if (x < 0 || x > w || y < 0 || y > h) return new double[] {0, 0};
            //
            // return new[]
            // {
            //     x <= margin ? 0 : x >= w - margin ? w : x,
            //     y <= margin ? 0 : y >= h - margin ? h : y
            // };
        }
    }
}