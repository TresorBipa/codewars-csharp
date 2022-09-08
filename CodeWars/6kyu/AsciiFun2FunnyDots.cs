/*
https://www.codewars.com/kata/59098c39d8d24d12b6000020/csharp

6 kyu
ASCII Fun #2: Funny Dots

Funny Dots
You will get two integers n (width) and m (height) and your task is to draw the following pattern. 
Each line is seperated with a newline (\n)

Both integers are equal or greater than 1; no need to check for invalid parameters.

Examples

                                            +---+---+---+
             +---+                          | o | o | o |
dot(1, 1) => | o |            dot(3, 2) =>  +---+---+---+            
             +---+                          | o | o | o |
                                            +---+---+---+

Serie: ASCII Fun
ASCII Fun #1: X-Shape
ASCII Fun #2: Funny Dots
ASCII Fun #3: Puzzle Tiles
ASCII Fun #4: Build a pyramid
*/


using System.Linq;

namespace CodeWars._6kyu;

public static class AsciiFun2FunnyDots
{
    public static string Dot(int n, int m)
    {
        var a = string.Concat(Enumerable.Repeat("+---", n)) + "+\n";
        var b = "" + string.Concat(Enumerable.Repeat("| o ", n)) + "|\n";
        return string.Concat(Enumerable.Repeat(a + b, m)) + a[..^1];
    }
}



