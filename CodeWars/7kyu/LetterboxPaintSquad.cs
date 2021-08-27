/*
https://www.codewars.com/kata/597d75744f4190857a00008d/csharp

7 kyu
Letterbox Paint-Squad

Story
You and a group of friends are earning some extra money in the school holidays by re-painting the numbers on people's letterboxes for a small fee.

Since there are 10 of you in the group each person just concentrates on painting one digit! 
For example, somebody will paint only the 1's, somebody else will paint only the 2's and so on...

But at the end of the day you realise not everybody did the same amount of work.

To avoid any fights you need to distribute the money fairly. That's where this Kata comes in.

Kata Task
Given the start and end letterbox numbers, write a method to return the frequency of all 10 digits painted.

Example
For start = 125, and end = 132

The letterboxes are

125 = 1, 2, 5
126 = 1, 2, 6
127 = 1, 2, 7
128 = 1, 2, 8
129 = 1, 2, 9
130 = 1, 3, 0
131 = 1, 3, 1
132 = 1, 3, 2
The digit frequencies are:

0 is painted 1 time
1 is painted 9 times
2 is painted 6 times
etc...
and so the method would return [1,9,6,3,0,1,1,1,1,1]

Notes
0 < start <= end
In C, the returned value will be free'd.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class LetterboxPaintSquad
    {
        public static IEnumerable<int> PaintLetterBoxes(int start, int end)
        {
            var str = string.Concat(Enumerable.Range(start, end - start + 1));
            return "0123456789".Select(x => str.Count(c => c == x));

            // return ("0123456789" + string.Concat(Enumerable.Range(start, end - start + 1)))
            //     .GroupBy(c => c)
            //     .Select(x => x.Count() - 1);


            // return string.Concat(Enumerable.Range(start, end - start + 1).Append(1234567890))
            //     .GroupBy(c => c)
            //     .OrderBy(g => g.Key)
            //     .Select(g => g.Count() - 1);


            // return string.Concat(Enumerable.Range(start, end - start + 1))
            //     .Concat("1234567890")
            //     .GroupBy(c => c)
            //     .OrderBy(g => g.Key)
            //     .Select(g => g.Count() - 1);


            // return Enumerable.Range(0, 10).Select(x =>
            //     string.Concat(Enumerable.Range(start, end - start + 1)).Count(z => z == x.ToString()[0]));


            // var r = Enumerable.Range(start, end - start + 1).SelectMany(x => x.ToString());
            // var r = string.Concat(Enumerable.Range(start, end - start + 1).Append(1234567890)).GroupBy(c => c);
            //var t = "0123456789".Select(v => r.Count(z => v == z) - 1);
            //return t;


            // return string.Concat(Enumerable.Range(start, end - start + 1).Concat(Enumerable.Range(0, 10)))
            //     .OrderBy(x => x)
            //     .GroupBy(x => x)
            //     .Select(x => x.Count() - 1)
            //     .ToArray();


            // string letters = "0123456789" + string.Concat(Enumerable.Range(start, end - start + 1));
            // return letters.GroupBy(c => c).OrderBy(g => g.Key).Select(g => g.Count() - 1);


            // return Enumerable.Range(0, 10).Select(x =>
            //     string.Join("", Enumerable.Range(start, end - start + 1)).Count(z => z == x.ToString()[0]));


            // var numbers = string.Concat(Enumerable.Range(start, end - start + 1));
            // return Enumerable.Range(0, 10).Select(i => numbers.Count(c => char.GetNumericValue(c) == i));


            // int[] result = new int[] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
            // for (int i = start; i <= end; i++)
            //     foreach (char ch in i.ToString())
            //         result[int.Parse(ch.ToString())]++;
            // return result;


            // var a = Enumerable.Range(start, end - start + 1).Select(x => x.ToString()).SelectMany(x => x);
            // return Enumerable.Range(48, 10).Select(x => a.Count(y => y == x));


            // return Enumerable.Range(start, end - start + 1)
            //     .Append(1234567890)
            //     .SelectMany(x => x.ToString())
            //     .GroupBy(c => c)
            //     .OrderBy(g => g.Key)
            //     .Select(g => g.Count() - 1)
            //     .ToArray();


            // string str = string.Concat(Enumerable.Range(start, end - start + 1));
            // return "0123456789".Select((t, i) => Regex.Matches(str, "" + i).Count());

            // return Enumerable.Range(0, 10).Select(i =>
            //     Enumerable.Range(start, end - start + 1).Aggregate("", (s, n) => s + n)
            //         .Count(x => char.GetNumericValue(x) == i));


            // var r = Enumerable.Range(start, end - start + 1).SelectMany(x => x.ToString()).ToArray();
            // var t = Enumerable.Range(0, 10).Select(v => (r.Count(z => v.ToString() == z.ToString()))).ToArray();
            // return t;
            // return new int[10] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
        }
    }
}