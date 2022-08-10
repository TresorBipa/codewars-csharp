/*
https://www.codewars.com/kata/5ff50f64c0afc50008861bf0/csharp

7 kyu
Four/Seven

Four Seven
Simple kata, simple rules: your function should accept the inputs 4 and 7. 
If 4 is entered, the function should return 7. 
If 7 is entered, the function should return 4. 
Anything else entered as input should return 0. 
There's only one catch, your function cannot include if statements, switch statements, or the ternary operator.

There are some very simple ways of answering this problem, but I encourage you to try and be as creative as possible.

Good Luck!
*/


using System.Collections.Generic;

namespace CodeWars._7kyu
{
    public static class KataFourSeven
    {
        public static int FourSeven(int num)
        {
            return new Dictionary<int, int> {{4, 7}, {7, 4}}.GetValueOrDefault(num);
            // return Convert.ToInt32(num == 4 || num == 7) * (11 - num);


            // new Dictionary<int, int> {{4, 7}, {7, 4}}.TryGetValue(num, out var result);
            // return result;


            // try
            // {
            //     return new Dictionary<int, int> {{4, 7}, {7, 4}}[num];
            // }
            // catch (Exception e)
            // {
            //     return 0;
            // }
        }
    }
}