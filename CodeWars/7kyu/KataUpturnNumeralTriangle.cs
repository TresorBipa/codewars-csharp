/*
https://www.codewars.com/kata/564f3d49a06556d27c000077/csharp

7 kyu
Upturn Numeral Triangle

Task
Raj has got into a problem, he solved the triangle pattern but stuck in the codes of "inverse triangle". 
Help him with the codes and remember to get the output as per given in examples below.

Rules:
Take input as 'n' which is always a natural number
Space between each digit
No space after the rows end
Examples
pattern(5)

1 1 1 1 1
 2 2 2 2
  3 3 3
   4 4
    5
    
    
pattern(9)

  1 1 1 1 1 1 1 1 1
   2 2 2 2 2 2 2 2
    3 3 3 3 3 3 3
     4 4 4 4 4 4
      5 5 5 5 5
       6 6 6 6
        7 7 7
         8 8
          9
        
        
pattern(16)

1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1
 2 2 2 2 2 2 2 2 2 2 2 2 2 2 2
  3 3 3 3 3 3 3 3 3 3 3 3 3 3
   4 4 4 4 4 4 4 4 4 4 4 4 4
    5 5 5 5 5 5 5 5 5 5 5 5
     6 6 6 6 6 6 6 6 6 6 6
      7 7 7 7 7 7 7 7 7 7
       8 8 8 8 8 8 8 8 8
        9 9 9 9 9 9 9 9
         0 0 0 0 0 0 0
          1 1 1 1 1 1
           2 2 2 2 2
            3 3 3 3
             4 4 4
              5 5
               6
*/

using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class KataUpturnNumeralTriangle
    {
        public static string UpturnNumeralTriangle(int n)
        {
            return string.Join("\n",
                Enumerable.Range(1, n).Select(i =>
                    new string(' ', i) + string.Join(" ", Enumerable.Repeat(i % 10, n + 1 - i))));


            // return string.Join("\n", Enumerable.Range(1, n).Select(i => new string(' ', i) +
            //                                                             string.Join(" ",
            //                                                                 (new string((char) ((i % 10) + '0'),
            //                                                                     n - i + 1)).ToCharArray())));


            // return string.Join("\n",
            //     Enumerable.Range(1, n).Select(i => string.Concat(
            //         Enumerable.Repeat(" ", i - 1).Concat(
            //             Enumerable.Repeat($" {i % 10}", n - i + 1)))));


            // return string.Join("\n",
            //     Enumerable.Range(1, n).Select(i =>
            //         $"{new string(' ', i)}{string.Join(" ", Enumerable.Repeat(i % 10, n + 1 - i))}"));


            // return string.Join("\n",
            //     Enumerable.Range(0, n).Select(i =>
            //         new string(' ', i) + string.Concat(Enumerable.Range(1, n - i).Select(y => $" {(i + 1) % 10}"))));


            // return string.Join("\n",
            //     Enumerable.Range(1, n).Select(x =>
            //         $"{new string(' ', x)}{new string('*', n - x + 1).Replace("*", $"{x % 10} ")}".TrimEnd()));


            // List<string> result = new List<string>();
            // for (int i = 1; i <= n; i++)
            // {
            //     result.Add(new string(' ', i) + string.Join(" ", Enumerable.Repeat(i % 10, n + 1 - i)));
            //     result.Add(new string(' ', i) + string.Join(" ", new string($"{i % 10}"[0], n + 1 - i).ToArray()));
            //     result.Add($"{new string(' ', i)}{string.Join(" ", new string($"{i % 10}"[0], n + 1 - i).ToArray())}");
            // }
            //
            // return string.Join("\n", result);
        }
    }
}