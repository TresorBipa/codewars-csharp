/*
https://www.codewars.com/kata/55caef80d691f65cb6000040/csharp

7 kyu
Geometric Progression Sequence

In your class, you have started lessons about geometric progression. Since you are also a programmer, 
you have decided to write a function that will print first n elements of the sequence with the given constant r and first element a.

Result should be separated by comma and space.

Example
Kata.GeometricSequenceElements(2, 3, 5); // => "2, 6, 18, 54, 162"
More info: https://en.wikipedia.org/wiki/Geometric_progression
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class GeometricProgressionSequence
    {
        public static string GeometricSequenceElements(int a, int r, int n)
        {
            return string.Join(", ", Enumerable.Range(0, n).Select(i => Math.Pow(r, i) * a));
        }
    }
}