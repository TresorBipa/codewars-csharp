/*
https://www.codewars.com/kata/5982619d2671576e90000017/csharp

7 kyu
sPoNgEbOb MeMe

Remember the spongebob meme that is meant to make fun of people by repeating what they say in a mocking way?

You need to create a function that converts the input into this format, 
with the output being the same string expect there is a pattern of uppercase and lowercase letters.

Examples:

spongeMeme("stop Making spongebob Memes!") // => 'StOp mAkInG SpOnGeBoB MeMeS!'
spongeMeme("colored teens cant Be successful in tech") // =>'CoLoReD TeEnS CaNt bE SuCcEsSfUl iN TeCh'
*/

using System.Linq;

namespace CodeWars
{
    public class sPoNgEbObMeMe
    {
        public static string SpongeMeme(string sentence)
        {
            return string.Concat(sentence.Select((c, i) => i % 2 == 1 ? char.ToLower(c) : char.ToUpper(c)));
        }
    }
}