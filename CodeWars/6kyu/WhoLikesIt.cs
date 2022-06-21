/*
https://www.codewars.com/kata/who-likes-it/csharp
https://www.codewars.com/kata/5266876b8f4bf2da9b000362/csharp

6 kyu
Who likes it?

You probably know the "like" system from Facebook and other pages. 
People can "like" blog posts, pictures or other items. 
We want to create the text that should be displayed next to such an item.

Implement the function which takes an array containing the names of people that like an item. 
It must return the display text as shown in the examples:

[]                                -->  "no one likes this"
["Peter"]                         -->  "Peter likes this"
["Jacob", "Alex"]                 -->  "Jacob and Alex like this"
["Max", "John", "Mark"]           -->  "Max, John and Mark like this"
["Alex", "Jacob", "Mark", "Max"]  -->  "Alex, Jacob and 2 others like this"
Note: For 4 or more names, the number in "and 2 others" simply increases.
*/

namespace CodeWars._6kyu;

public static class WhoLikesIt
{
    public static string Likes(string[] name)
    {
        return name.Length switch
        {
            0 => "no one likes",
            1 => $"{name[0]} likes",
            2 => $"{name[0]} and {name[1]} like",
            3 => $"{name[0]}, {name[1]} and {name[2]} like",
            _ => $"{name[0]}, {name[1]} and {name.Length - 2} others like"
        } + " this";

        // var len = name.Length;
        // return name.Length switch
        // {
        //     1 => $"{name[0]} likes this",
        //     2 => $"{name[0]} and {name[1]} like this",
        //     3 => $"{name[0]}, {name[1]} and {name[2]} like this",
        //     _ => len >= 4 ? $"{name[0]}, {name[1]} and {len - 2} others like this" : "no one likes this"
        // };
    }
}