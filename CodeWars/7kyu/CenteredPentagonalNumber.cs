/*
https://www.codewars.com/kata/5fb856190d5230001d48d721/csharp

7 kyu
Centered pentagonal number

Centered pentagonal number
Complete the function that takes an integer and calculates how many dots exist in a pentagonal shape around the center dot on the Nth iteration.

In the image below you can see the first iteration is only a single dot. On the second, there are 6 dots. 
On the third, there are 16 dots, and on the fourth there are 31 dots. The sequence is: 1, 6, 16, 31...

pentagons

If the input is equal to or less than 0, return -1

Examples
1  -->    1
2  -->    6
8  -->  141
0  -->   -1
*/

namespace CodeWars._7kyu
{
    public static class CenteredPentagonalNumber
    {
        public static long Pentagonal(long n)
        {
            return n > 0 ? (n - 1) * n / 2 * 5 + 1 : -1;
        }
    }
}