/*
https://www.codewars.com/kata/51e0007c1f9378fa810002a9/csharp

6 kyu
Make the Deadfish swim

Write a simple parser that will parse and run Deadfish.

Deadfish has 4 commands, each 1 character long:

i increments the value (initially 0)
d decrements the value
s squares the value
o outputs the value into the return array
Invalid characters should be ignored.

Deadfish.Parse("iiisdoso") => new int[] {8, 64};
*/

using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class MakeDeadfishSwim
    {
        public static int[] Parse(string data, int i = 0)
        {
            return data.Aggregate(new List<int>(), (a, c) =>
            {
                if (c == 'i') i++;
                else if (c == 'd') i--;
                else if (c == 's') i *= i;
                else if (c == 'o') a.Add(i);
                return a;
            }).ToArray();


            // return data.Select(x => new
            //     {
            //         Command = x,
            //         result = x switch
            //         {
            //             'i' => i++,
            //             'd' => i--,
            //             's' => i *= i,
            //             'o' => i,
            //             _ => -1
            //         }
            //     })
            //     .Where(r => r.Command == 'o')
            //     .Select(x => x.result).ToArray();


            // var output = new List<int>();
            // foreach (var c in data)
            // {
            //     switch (c)
            //     {
            //         case 'i':
            //             i++;
            //             break;
            //         case 'd':
            //             i--;
            //             break;
            //         case 's':
            //             i *= i;
            //             break;
            //         case 'o':
            //             output.Add(i);
            //             break;
            //     }
            // }
            //
            // return output.ToArray();


            // int result = 0;
            // List<int> output = new List<int>();
            // foreach (var c in data.Where(x => "idso".Contains(x)))
            // foreach (var c in data)
            // {
            //     if (c == 'i') result += 1;
            //     if (c == 'd') result -= 1;
            //     if (c == 's') result *= result;
            //     if (c == 'o') output.Add(result);
            // }
            // return output.ToArray();
        }
    }
}