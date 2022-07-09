/*
https://www.codewars.com/kata/55b42574ff091733d900002f/csharp

7 kyu
Friend or Foe?

Make a program that filters a list of strings and returns a list with only your friends name in it.
If a name has exactly 4 letters in it, you can be sure that it has to be a friend of yours! Otherwise, you can be sure he's not...
Ex: Input = ["Ryan", "Kieran", "Jason", "Yous"], Output = ["Ryan", "Yous"]

i.e.

friend ["Ryan", "Kieran", "Mark"] `shouldBe` ["Ryan", "Mark"]
Note: keep the original order of the names in the output.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class KataFriendOrFoe
    {
        public static IEnumerable<string> FriendOrFoe(string[] names)
        {
            return names.Where(s => s.Length == 4);
            // return Array.FindAll(names, n => n.Length == 4);
        }
    }
}