/*
https://www.codewars.com/kata/566f571ed78037c7b6000036/csharp

7 kyu
Get Length

Get Length
You don't have any idea what is the type of the input object, 
but you know that it has Length property. (The input can be any type of object that has Length property)

So, the GetLength method should return the Length of input.
*/

namespace CodeWars
{
    public class KataGetLength
    {
        public static int GetLength(dynamic input)
        {
            return input.Length;
        }
    }
}