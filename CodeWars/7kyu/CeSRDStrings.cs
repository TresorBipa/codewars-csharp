/*
https://www.codewars.com/kata/5ff6060ed14f4100106d8e6f/csharp

7 kyu
Ce*s*r*d Strings

Caution: This kata does not currently have any known supported versions for C#. 
It may not be completable due to dependencies on out-dated libraries/language versions.
My PC got infected by a strange virus. It only infects my text files and replaces random letters by *, li*e th*s (like this).

Fortunately, I discovered that the virus hides my censored letters inside root directory.

It will be very tedious to recover all these files manually, so your goal is to implement uncensor function that does the hard work automatically.

Examples
uncensor("*h*s *s v*ry *tr*ng*", "Tiiesae") ➜ "This is very strange"

uncensor("A**Z*N*", "MAIG") ➜ "AMAZING"

uncensor("xyz", "") ➜ "xyz"
Notes
Expect all discovered letters to be given in the correct order.
Discovered letters will match the number of censored ones.
Any character can be censored.
*/


using System.Linq;
using System.Text;

namespace CodeWars._7kyu;

public static class CeSRDStrings
{
    // public static string Uncensor(string infected, string discovered, int index = 0)
    public static string Uncensor(string infected, string discovered)
    {
        // var index = 0;
        // return string.Concat(infected.Select(c => c == '*' ? discovered[index++] : c));

        var index = 0;
        var sb = new StringBuilder();
        foreach (var c in infected)
        {
            sb.Append(c == '*' ? discovered[index++] : c);
        }

        return sb.ToString();
    }
}