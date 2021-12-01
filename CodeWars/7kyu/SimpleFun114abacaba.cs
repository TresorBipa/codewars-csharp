/*
https://www.codewars.com/kata/589d237fdfdef0239a00002e/csharp

7 kyu
Simple Fun #114: "abacaba"

Task
Consider the following algorithm for constructing 26 strings S(1) .. S(26):

S(1) = "a";
For i in [2, 3, ..., 26]:
S(i) = S(i - 1) + character(i) + S(i - 1).```

For example:
S(1) = "a" S(2) = S(1) + "b" + S(1) = "a" + "b" + "a" = "aba" S(3) = S(2) + "c" + S(2) = "aba" + "c" +"aba" = "abacaba" ... S(26) = S(25) + "z" + S(25)``` 
Finally, we got a long string S(26). 
Your task is to find the kth symbol (indexing from 1) in the string S(26). All strings consist of lowercase letters only.

Input / Output
[input] integer k

1 ≤ k < 226

[output] a string(char in C#)

the kth symbol of S(26)
*/

using System;

namespace CodeWars
{
    public class SimpleFun114abacaba
    {
        public char abacaba(int k)
        {
            // var symbol = 'a';
            // while (k % 2 == 0)
            // {
            //     symbol++;
            //     k /= 2;
            // }
            //
            // return symbol;


            return (char) (97 + (int) Math.Log2(k & -k));
            // return (char) (Convert.ToString(k ^ (k - 1), 2).Length + 96);
        }
    }
}