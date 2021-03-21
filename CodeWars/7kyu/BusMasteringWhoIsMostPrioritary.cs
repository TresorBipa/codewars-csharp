﻿/*
https://www.codewars.com/kata/5a0366f12b651dbfa300000c/csharp

7 kyu
Bus mastering - Who is the most prioritary?

When multiple master devices are connected to a single bus (https://en.wikipedia.org/wiki/System_bus), 
there needs to be an arbitration in order to choose which of them can have access to the bus (and 'talk' with a slave).

We implement here a very simple model of bus mastering. 
Given n, a number representing the number of masters connected to the bus, 
and a fixed priority order (the first master has more access priority than the second and so on...), 
the task is to choose the selected master. 
In practice, you are given a string inp of length n representing the n masters' requests to get access to the bus, 
and you should return a string representing the masters, showing which (only one) of them was granted access:

The string 1101 means that master 0, master 1 and master 3 have requested
access to the bus. 
Knowing that master 0 has the greatest priority, the output of the function should be: 1000
Examples
* arbitrate("001000101", 9) -> "001000000"

* arbitrate("000000101", 9) -> "000000100"
Notes
The resulting string (char* ) should be allocated in the arbitrate function, and will be free'ed in the tests.

n is always greater or equal to 1.
*/

using System.Linq;

namespace CodeWars
{
    public class BusMasteringWhoIsMostPrioritary
    {
        public static string arbitrate(string input, int length)
        {
            // return string.Concat(input.TakeWhile((x, i) => x == '0' || i == input.IndexOf("1"))).PadRight(length, '0');
            // return input.Substring(0, input.IndexOf("1") + 1) + new string('0', length - input.IndexOf("1") - 1);
            // return input.Substring(0, input.IndexOf('1') + 1).PadRight(length, '0');
            return input[..(input.IndexOf('1') + 1)].PadRight(length, '0');
        }
    }
}