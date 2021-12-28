/*
https://www.codewars.com/kata/58bfa1ea43fadb41840000b4/csharp

7 kyu
Simple Fun #190: Folding Paper

Task
John was in math class and got bored, so he decided to fold some origami from a rectangular a × b sheet of paper (a > b). 
His first step is to make a square piece of paper from the initial rectangular piece of paper by folding the sheet along the bisector of the right angle and cutting off the excess part.

After moving the square piece of paper aside, John wanted to make even more squares! He took the remaining (a-b) × b strip of paper and went on with the process until he was left with a square piece of paper.

Your task is to determine how many square pieces of paper John can make.

Example:
For: a = 2, b = 1, the output should be 2.

Given a = 2 and b = 1, John can fold a 1 × 1 then another 1 × 1.

So the answer is 2.

For: a = 10, b = 7, the output should be 6.

We are given a = 10 and b = 7. The following is the order of squares John folds: 7 × 7, 3 × 3, 3 × 3, 1 × 1, 1 × 1, and 1 × 1.

Here are pictures for the example cases.


Input/Output
[input] integer a

2 ≤ a ≤ 1000

[input] integer b

1 ≤ b < a ≤ 1000

[output] an integer

The maximum number of squares.
*/

using System;

namespace CodeWars
{
    public class SimpleFun190FoldingPaper
    {
        public int Folding(int a, int b)
        {
            return a / b + (a % b > 0 ? Folding(b, a % b) : 0);
            // return a - b == 0 ? 1 : 1 + Folding(Math.Abs(a - b), Math.Min(a, b));

            // var count = 0;
            // while (a > 0 && b > 0)
            // {
            //     if (a <= b) b -= a;
            //     else a -= b;
            //     count++;
            // }
            //
            // return count;


            // int c = 0;
            //
            // while (a != b)
            // {
            //     if (a > b) a -= b;
            //     else b -= a;
            //     ++c;
            // }
            //
            // return c + 1;
        }
    }
}