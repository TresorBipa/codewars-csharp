/*
https://www.codewars.com/kata/56a6ce697c05fb4667000029/csharp

7 kyu
Next Palindromic Number.

There were and still are many problem in CW about palindrome numbers and palindrome strings. 
We suposse that you know which kind of numbers they are. If not, 
you may search about them using your favourite search engine.

In this kata you will be given a positive integer, 
val and you have to create the function next_pal()(nextPal Javascript) that will output the smallest palindrome number higher than val.

Let's see:

For C#
Kata.NextPal(11) == 22

Kata.NextPal(188) == 191

Kata.NextPal(191) == 202

Kata.NextPal(2541) == 2552
You will be receiving values higher than 10, all valid.

Enjoy it!!
*/

using System.Linq;

namespace CodeWars
{
    public class NextPalindromicNumber
    {
        public static int NextPal(int val)
        {
            // do
            // {
            //     val++;
            // } while (val.ToString() != string.Concat(val.ToString().Reverse()));
            //
            // return val;


            // while (true)
            // {
            //     val += 1;
            //     if (string.Join("", val.ToString().ToCharArray().Reverse()) == val.ToString())
            //     {
            //         return val;
            //     }
            // }

            // val++;
            // while (!$"{val}".SequenceEqual($"{val}".Reverse()))
            //     val++;
            // return val;


            // while ((++val).ToString() != new string(val.ToString().Reverse().ToArray()))
            // {
            // }
            // return val;

            //return Enumerable.Range(val + 1, val).First(x => x.ToString() == new string(x.ToString().Reverse().ToArray()));
            return Enumerable.Range(val + 1, val).First(x => $"{x}" == string.Concat($"{x}".Reverse()));
        }
    }
}