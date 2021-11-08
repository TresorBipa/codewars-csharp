/*
https://www.codewars.com/kata/59414b46d040b7b8f7000021/csharp

7 kyu
Turn any word into a beef taco

If you like Taco Bell, you will be familiar with their signature doritos locos taco. They're very good.

Why can't everything be a taco? We're going to attempt that here, turning every word we find into the taco bell recipe with each ingredient.

We want to input a word as a string, and return a list representing that word as a taco.

Key

all vowels (except 'y') = beef

t = tomato

l = lettuce

c = cheese

g = guacamole

s = salsa

NOTE
We do not care about case here. 'S' is therefore equivalent to 's' in our taco.

Ignore all other letters; we don't want our taco uneccesarily clustered or else it will be too difficult to eat.

Note that no matter what ingredients are passed, our taco will always have a shell.
*/

using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class TurnAnyWordIntoBeefTaco
    {
        public static string[] Tacofy(string word)
        {
            return new List<string> { "shell" }.Concat(word.ToLower().Where(c => "aeioutlcgs".Contains(c))
                .Select(c => c switch
                {
                    't' => "tomato",
                    'c' => "cheese",
                    'g' => "guacamole",
                    'l' => "lettuce",
                    's' => "salsa",
                    _ => "beef"
                })).Append("shell").ToArray();
        }
    }
}