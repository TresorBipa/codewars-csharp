/*
https://www.codewars.com/kata/5838e2978bbc04b7cd000008/csharp

7 kyu
Ten Green Bottles

Who knows the nursery rhyme Ten Green Bottles?

Lyrics:

Ten green bottles hanging on the wall,
Ten green bottles hanging on the wall,
And if one green bottle should accidentally fall,
There'll be nine green bottles hanging on the wall.

Nine green bottles hanging on the wall,
Nine green bottles hanging on the wall,
And if one green bottle should accidentally fall,
There'll be eight green bottles hanging on the wall. 

Eight green bottles hanging on the wall...
Seven green bottles hanging on the wall...
...

One green bottle hanging on the wall,
One green bottle hanging on the wall,
If that one green bottle should accidentally fall,
There'll be no green bottles hanging on the wall.
Task
Write some amazing code to reproduce the above lyrics starting from n green bottles!
*/

using System.Linq;

namespace CodeWars
{
    public class KataTenGreenBottles
    {
        public static string TenGreenBottles(int n)
        {
            var d = new[] {"One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten"};

            return string.Join("\n", Enumerable.Range(1, n).Select(i =>
                    $"{d[i - 1]} green bottle{(i > 1 ? "s" : "")} hanging on the wall,\n" +
                    $"{d[i - 1]} green bottle{(i > 1 ? "s" : "")} hanging on the wall,\n" +
                    (i > 1
                        ? "And if one green bottle should accidentally fall,\n"
                        : "If that one green bottle should accidentally fall,\n") +
                    (i > 1
                        ? $"There'll be {d[i - 2].ToLower()} green bottle{(i - 1 > 1 ? "s" : "")} hanging on the wall.\n"
                        : "There'll be no green bottles hanging on the wall.\n")
                ).Reverse()
            );


            // string[] num = {"no", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten"};
            // var result = "";
            //
            // for (var i = n; i > 0; i--)
            // {
            //     result += $"{num[i]} green bottle{(i == 1 ? "" : "s")} hanging on the wall,\n" +
            //               $"{num[i]} green bottle{(i == 1 ? "" : "s")} hanging on the wall,\n" +
            //               $"{(i == 1 ? "If that" : "And if")} one green bottle should accidentally fall,\n" +
            //               $"There'll be {num[i - 1].ToLower()} green bottle{(i == 2 ? "" : "s")} hanging on the wall.\n" +
            //               $"{(i == 1 ? "" : "\n")}";
            // }
            //
            // return result;
        }
    }
}