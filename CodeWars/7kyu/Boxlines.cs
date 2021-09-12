/*
https://www.codewars.com/kata/6129095b201d6b000e5a33f0/csharp

7 kyu
Boxlines

Boxlines
Given a X*Y*Z box built by arranging 1*1*1 unit boxes, 
write a function f(X,Y,Z) that returns the number of edges (hence, boxlines) of length 1 (both inside and outside of the box)

Notes
Adjacent unit boxes share the same edges, so a 2*1*1 box will have 20 edges, not 24 edges
X,Y and Z are strictly positive, and can go as large as 2^16 - 1
This is my first kata, so I hope every one will enjoy it <3
*/

namespace CodeWars
{
    public class Boxlines
    {
        public static ulong F(ushort x, ushort y, ushort z)
        {
            return x * (y + 1UL) * (z + 1UL) +
                   y * (z + 1UL) * (x + 1UL) +
                   z * (x + 1UL) * (y + 1UL);

            // return (ulong) ((x + 1) * (y + 1) * z + (x + 1) * y * (z + 1) + x * (y + 1) * (z + 1));

            // var X = x * (1UL + y) * (1UL + z);
            // var Y = y * (1UL + x) * (1UL + z);
            // var Z = z * (1UL + y) * (1UL + x);
            // return X + Z + Y;
        }
    }
}