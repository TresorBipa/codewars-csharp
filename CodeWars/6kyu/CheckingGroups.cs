/*
https://www.codewars.com/kata/54b80308488cb6cd31000161/csharp

6 kyu
Checking Groups

In English and programming, groups can be made using symbols such as () and {} that change meaning. 
However, these groups must be closed in the correct order to maintain correct syntax.

Your job in this kata will be to make a program that checks a string for correct grouping. 

For instance, the following groups are done correctly:
({})
[[]()]
[{()}]

The next are done incorrectly:
{(})
([]
[])
A correct string cannot close groups in the wrong order, open a group but fail to close it, or close a group before it is opened.

Your function will take an input string that may contain any of the symbols (), {} or [] to create groups.

It should return True if the string is empty or otherwise grouped correctly, or False if it is grouped incorrectly.
*/

using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class CheckingGroups
    {
        public static bool Check(string input)
        {
            var re = new Regex(@"(\[\]|\{\}|\(\))");
            while (re.IsMatch(input = re.Replace(input, "")));
            return input.Length == 0;


            // const string pattern = @"(\(\))|(\[\])|(\{\})";
            // while (Regex.IsMatch(input = Regex.Replace(input, pattern, ""), pattern)) ;
            // return input.Length == 0;


            // Regex _pattern = new Regex(@"\[\]|\{\}|\(\)");
            // while (_pattern.IsMatch(input))
            // {
            //     input = _pattern.Replace(input, string.Empty);
            // }
            // return string.IsNullOrWhiteSpace(input);


            // Regex r = new Regex(@"(\[\])|(\{\})|(\(\))");
            //
            // while (true)
            // {
            //     if (r.IsMatch(input))
            //     {
            //         input = r.Replace(input, "");
            //     }
            //     else
            //     {
            //         break;
            //     }
            // }
            //
            // return string.IsNullOrEmpty(input);


            // foreach (char ch in input)
            // {
            //     input = input.Replace("()", "");
            //     input = input.Replace("{}", "");
            //     input = input.Replace("[]", "");
            // }
            //
            // return input == string.Empty;


            // string previousState = "";
            // while (previousState != input)
            // {
            //     previousState = input;
            //     input = input.Replace("()", "")
            //         .Replace("{}", "")
            //         .Replace("[]", "");
            // }
            //
            // return input.Length == 0;


            // while (input.Contains("()") || input.Contains("[]") || input.Contains("{}"))
            // {
            //     input = input.Replace("()", "");
            //     input = input.Replace("[]", "");
            //     input = input.Replace("{}", "");
            // }
            //
            // return !input.Any();
        }
    }
}