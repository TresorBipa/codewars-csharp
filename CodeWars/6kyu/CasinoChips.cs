/*
https://www.codewars.com/kata/5e0b72d2d772160011133654/csharp

6 kyu
Casino chips

You are given three piles of casino chips: white, green and black chips:

the first pile contains only white chips
the second pile contains only green chips
the third pile contains only black chips
Each day you take exactly two chips of different colors and head to the casino. Y
ou can choose any color, but you are not allowed to take two chips of the same color in a day.

You will be given an array representing the number of chips of each color and your task is to return the maximum number of days you can pick the chips. 
Each day you need to take exactly two chips.

solve([1,1,1]) // = 1, because after you pick on day one, there will be only one chip left
solve([1,2,1]) // = 2, you can pick twice; you pick two chips on day one then on day two
solve([4,1,1]) // = 2 
More examples in the test cases. Good luck!

Brute force is not the way to go here. Look for a simplifying mathematical approach.
*/


using System;
using System.Linq;

namespace CodeWars
{
    public static class CasinoChips
    {
        public static int solve(int[] arr)
        {
            var sum = arr.Sum();
            return Math.Min(sum / 2, sum - arr.Max());
        }
    }
}