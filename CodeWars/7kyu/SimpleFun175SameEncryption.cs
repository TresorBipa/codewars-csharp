/*
https://www.codewars.com/kata/58b6c403a38abaaf6c00006b/csharp

7 kyu
Simple Fun #175: Same Encryption

Task
John loves encryption. He can encrypt any string by the following algorithm:

take the first and the last letters of the word;
replace the letters between them with their number;
replace this number with the sum of it digits 
          until a single digit is obtained.```
Given two strings(`s1` and `s2`), return `true` if their encryption is the same, or `false` otherwise.

# Example

 For `s1 = "EbnhGfjklmjhgz" and s2 = "Eabcz"`, the result should be `true`.
"EbnhGfjklmjhgz" --> "E12z" --> "E3z" "Eabcz" --> "E3z" Their encryption is the same.```

Input/Output
[input] string s1

The first string to be encrypted.

s1.length >= 3

[input] string s2

The second string to be encrypted.

s2.length >= 3

[output] a boolean value

true if encryption is the same, false otherwise.
*/

namespace CodeWars
{
    public class SimpleFun175SameEncryption
    {
        public bool SameEncryption(string s1, string s2)
        {
            return s1[0] == s2[0] && s1[^1] == s2[^1] && (s1.Length - 2) % 9 == (s2.Length - 2) % 9;
        }
    }
}