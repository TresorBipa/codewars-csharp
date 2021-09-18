/*
https://www.codewars.com/kata/564ab935de55a747d7000040/csharp

7 kyu
Not all but sometimes all

Write

public static string Remove(string str, Dictionary<char,int> what)
that takes in a string str(text in Python) and an object/hash/dict/Dictionary what and returns a string with the chars removed in what. For example:

Kata.Remove("this is a string", new Dictionary<char,int> { {'t', 1 }, {'i', 2 }}); // --> "hs s a string"
// remove from 'this is a string' the first 1 't' and the first 2 i's.
Kata.Remove("hello world", new Dictionary<char,int> { { 'x',5 }, {'i',2 }}); // --> "hello world"
// there are no x's or i's, so nothing gets removed
Kata.Remove("apples and bananas", new Dictionary<char,int> { {'a', 50 }, {'n', 1 }}); // --> "pples d bnns"
// we don't have 50 a's, so just remove it till we hit end of string.
*/

using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class NotAllButSometimesAll
    {
        public static string Remove(string str, Dictionary<char, int> what)
        {
            return new string(str.Where(c => !what.ContainsKey(c) || what[c]-- < 1).ToArray());
            // return string.Concat(str.Where(c => !what.ContainsKey(c) || what[c]-- < 1).ToArray());
            // return str.Where(c => !what.ContainsKey(c) || what[c]-- < 1).Aggregate("", (s, c) => s + c);


            // var result = "";
            // foreach (var c in str)
            // {
            //     if (!what.ContainsKey(c) || what[c]-- < 1)
            //     {
            //         result += c;
            //     }
            // }
            //
            // return result;
        }
    }
}