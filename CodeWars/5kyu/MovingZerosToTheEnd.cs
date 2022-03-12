/*
https://www.codewars.com/kata/52597aa56021e91c93000cb0/csharp

5 kyu
Moving Zeros To The End

Write an algorithm that takes an array and moves all of the zeros to the end, preserving the order of the other elements.

Kata.MoveZeroes(new int[] {1, 2, 0, 1, 0, 1, 0, 3, 0, 1}) => new int[] {1, 2, 1, 1, 3, 1, 0, 0, 0, 0}
*/

using System.Linq;

namespace CodeWars
{
    public class MovingZerosToTheEnd
    {
        public static int[] MoveZeroes(int[] arr)
        {
            // return arr.OrderBy(0.Equals).ToArray();
            return arr.OrderBy(i => i == 0).ToArray();
            // return arr.Where(i => i != 0).Concat(arr.Where(i => i == 0)).ToArray();
        }
    }
}