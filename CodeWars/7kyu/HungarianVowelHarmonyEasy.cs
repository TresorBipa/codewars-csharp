/*
https://www.codewars.com/kata/57fd696e26b06857eb0011e7/csharp

7 kyu
Hungarian Vowel Harmony (easy)

Vowel harmony is a phenomenon in some languages. 
It means that "A vowel or vowels in a word are changed to sound the same (thus "in harmony.")" (wikipedia). 
This kata is based on vowel harmony in Hungarian.

Task:
Your goal is to create a function dative() (Dative() in C#) which returns the valid form of a valid Hungarian word w in dative case i. e. append the correct suffix nek or nak to the word w based on vowel harmony rules.

Vowel Harmony Rules (simplified)
When the last vowel in the word is

a front vowel (e, é, i, í, ö, ő, ü, ű) the suffix is -nek
a back vowel (a, á, o, ó, u, ú) the suffix is -nak
Examples:
Kata.Dative("ablak") == "ablaknak"
Kata.Dative("szék") == "széknek"
Kata.Dative("otthon") == "otthonnak"
Preconditions:
To keep it simple: All words end with a consonant :)
All strings are unicode strings.
There are no grammatical exceptions in the tests.
*/

using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class HungarianVowelHarmonyEasy
    {
        public static string Dative(string word)
        {
            //return word += "aáoóuú".Contains(word.Where(c => "eéiíöőüűaáoóuú".Contains(c)).Last()) ? "nak" : "nek";
            //return $"{word}{("aáoóuú".Contains(word.Last(c => "eéiíöőüűaáoóuú".Contains(c))) ? "nak" : "nek")}";
            //return word += "aáoóuú".Contains(word.Last(c => "eéiíöőüűaáoóuú".Contains(c))) ? "nak" : "nek";
            return word + ("aáoóuú".Contains(word.Last(c => "eéiíöőüűaáoóuú".Contains(c))) ? "nak" : "nek");
            //return word + (Regex.IsMatch(word, @".*[aáoóuú].{1,3}$") ? "nak" : "nek");


            // return word +
            //        (word.LastIndexOfAny(new[] {'e', 'é', 'i', 'í', 'ö', 'ő', 'ü', 'ű'}) >
            //         word.LastIndexOfAny(new[] {'a', 'á', 'o', 'ó', 'u', 'ú'})
            //            ? "nek"
            //            : "nak");


            // string frontVowels = "eéiíöőüű";
            // string backVowels = "aáoóuú";
            // string vowels = frontVowels + backVowels;
            // return backVowels.Contains(word.Last(letter => vowels.Contains(letter)))
            //     ? word + "nak"
            //     : word + "nek";


            // for (int i = word.Length - 1; i >= 0; i--)
            // {
            //     if ("eéiíöőüű".Contains(word[i])) return word + "nek";
            //     if ("aáoóuú".Contains(word[i])) return word + "nak";
            // }
            // return word;


            // foreach (var ch in word.ToCharArray().Reverse())
            // {
            //     // if (Regex.IsMatch(ch.ToString(), "[e, é, i, í, ö, ő, ü, ű]")) return word + "nek";
            //     // if (Regex.IsMatch(ch.ToString(), "[a, á, o, ó, u, ú]")) return word + "nak";
            //     if ("eéiíöőüű".Contains(ch)) return word + "nek";
            //     if ("aáoóuú".Contains(ch)) return word + "nak";
            // }
            // return string.Empty;


            // return word.LastIndexOfAny(new[] {'e', 'é', 'i', 'í', 'ö', 'ő', 'ü', 'ű'}) >
            //        word.LastIndexOfAny(new[] {'a', 'á', 'o', 'ó', 'u', 'ú'})
            //     ? word + "nek"
            //     : word + "nak";
        }
    }
}