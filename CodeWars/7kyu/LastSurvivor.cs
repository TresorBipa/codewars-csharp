/*
https://www.codewars.com/kata/609eee71109f860006c377d1/csharp

7 kyu
Last Survivor

You are given a string of letters and an array of numbers.
The numbers indicate positions of letters that must be removed, in order, starting from the beginning of the array.
After each removal the size of the string decreases (there is no empty space).
Return the only letter left.

Example:

let str = "zbk", arr = [0, 1]
    str = "bk", arr = [1]
    str = "b", arr = []
    return 'b'
Notes
The given string will never be empty.
The length of the array is always one less than the length of the string.
All numbers are valid.
There can be duplicate letters and numbers.
If you like this kata, check out the next one: Last Survivors Ep.2
*/

using System.Linq;

namespace CodeWars
{
    public class KataLastSurvivor
    {
        public static string LastSurvivor(string letters, int[] coords)
        {
            return coords.Aggregate(letters, (s, i) => s[..i] + s[(i + 1)..]);
            // return coords.Aggregate(letters, (current, index) => current.Remove(index, 1));
            // return coords.Aggregate(letters, (s, i) => s.Substring(0, i) + s.Substring(i + 1));
        }
    }
}