/*
https://www.codewars.com/kata/55e6125ad777b540d9000042/csharp

7 kyu
Invalid Input - Error Handling #1

Error Handling is very important in coding and seems to be overlooked or not implemented properly.

#Task
Your task is to implement a function which takes a string as input and return an object containing the properties vowels and consonants. 
The vowels property must contain the total count of vowels {a,e,i,o,u}, and the total count of consonants {a,..,z} - {a,e,i,o,u}. 
Handle invalid input and don't forget to return valid ones.

#Input
The input is any random string. 
You must then discern what are vowels and what are consonants and sum for each category their total occurrences in an object. 
However you could also receive inputs that are not strings. 
If this happens then you must return an object with a vowels and consonants total of 0 because the input was NOT a string. 
Refer to the Example section for a more visual representation of which inputs you could receive and the outputs expected. :)

Example:
C#
A Counter class has been put in the preloaded section taking two parameters Vowels and Consonants this must be the Object you return!

public class Counter {
    public int Vowels { get; set; }
    public int Consonants { get; set; }
    public Counter(int vowels, int consonants)
    {
        Vowels = vowels;
        Consonants = consonants;
    }
}
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class InvalidInputErrorHandling1
    {
        public class Counter
        {
            public int Vowels { get; set; }
            public int Consonants { get; set; }

            public Counter(int vowels, int consonants)
            {
                Vowels = vowels;
                Consonants = consonants;
            }
        }

        public static Counter GetCount(object word)
        {
            var s = (word as string ?? "").ToLower().Where(char.IsLetter).ToArray();
            //return new Counter(s.Count("aeiou".Contains), s.Count("bcdfghjklmnpqrstvwxyz".Contains));
            return new Counter(s.Count("aeiou".Contains), s.Count(c => !"aeiou".Contains(c)));


            // Counter ret = new Counter(0, 0);
            // if (word is string)
            // {
            //     var str = word.ToString().ToLower().Where(c => char.IsLetter(c));
            //     ret.Vowels = str.Count(c => "aeiou".Contains(c));
            //     ret.Consonants = str.Count() - ret.Vowels;
            // }
            // return ret;


            // if (word is string)
            //     return new Counter(Regex.Matches(word.ToString().ToLower(), "[aeiou]").Count,
            //         Regex.Matches(word.ToString().ToLower(), "[b-df-hj-np-t-v-z]").Count);
            // else return new Counter(0, 0);


            // Console.WriteLine("'" + word + "'");
            // var vowels = word.ToString()?.ToLower().Count(c => "aeiou".Contains(c)) ?? 0;
            // var consonants = word.ToString()?.ToLower().Count(c => !"aeiou".Contains(c) && char.IsLetter(c)) ?? 0;
            // return new Counter(vowels, consonants);
        }
    }
}