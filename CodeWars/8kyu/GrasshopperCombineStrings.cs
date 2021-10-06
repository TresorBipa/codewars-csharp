/*
https://www.codewars.com/kata/grasshopper-combine-strings/csharp
https://www.codewars.com/kata/55f73f66d160f1f1db000059/csharp

8 kyu
Grasshopper - Combine strings

Combine strings function
Create a function named combineNames(combine_names in python, ruby) that accepts two parameters (first and last name). The function should return the full name.

Example:

CombineNames("James", "Stevens")
returns:

"James Stevens"
*/

namespace CodeWars
{
    public class GrasshopperCombineStrings
    {
        public static string CombineNames(string a, string b)
        {
            return $"{a} {b}";
        }
    }
}