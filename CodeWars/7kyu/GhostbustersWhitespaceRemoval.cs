/*
https://www.codewars.com/kata/5668e3800636a6cd6a000018/csharp

7 kyu
Ghostbusters (whitespace removal)

Oh no! Ghosts have reportedly swarmed the city. It's your job to get rid of them and save the day!

In this kata, strings represent buildings while whitespaces within those strings represent ghosts.

So what are you waiting for? Return the building(string) without any ghosts(whitespaces)!

Example:

ghostBusters("Sky scra per");
Should return:

"Skyscraper"
If the building contains no ghosts, return the string:

"You just wanted my autograph didn't you?"
*/


using System.Linq;

namespace CodeWars._7kyu;

public class GhostbustersWhitespaceRemoval
{
    public static string GhostBusters(string building)
    {
        // return building.Any(c => c == ' ')
        //     ? string.Concat(building.Where(c => c != ' '))
        //     : "You just wanted my autograph didn't you?";

        // return building.IndexOf(' ') > -1
        //     ? string.Concat(building.Where(x => x != ' '))
        //     : "You just wanted my autograph didn't you?";

        // var s = building.Replace(" ", "");
        // return s.Length == building.Length
        //     ? "You just wanted my autograph didn't you?"
        //     : s;

        // return building.Contains(' ')
        //     ? building.Replace(" ", "")
        //     : "You just wanted my autograph didn't you?";

        return building.Contains(' ')
            ? building.Replace(" ", string.Empty)
            : "You just wanted my autograph didn't you?";
    }
}