/*
https://www.codewars.com/kata/57e3f79c9cb119374600046b/csharp

8 kyu
Hello, Name or World!

Define a method hello that returns "Hello, Name!" to a given name, or says Hello, World! if name is not given (or passed as an empty String).
Assuming that name is a String and it checks for user typos to return a name with a first capital letter (Xxxx).

Examples:
hello "john"   => "Hello, John!"
hello "aliCE"  => "Hello, Alice!"
hello          => "Hello, World!" # name not given
hello ""       => "Hello, World!" # name is an empty String
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Globalization;

namespace CodeWars
{
    public static class HelloNameOrWorld
    {
        public static string Hello(string name = "")
        {
            if (name == "") return "Hello, World!";

            return "Hello, " + name.Remove(1).ToUpper() + name.ToLower().Substring(1) + "!";


            // return string.IsNullOrEmpty(name)
            //     ? "Hello, World!"
            //     : $"Hello, {name[..1].ToUpper()}{name[1..].ToLower()}!";

            // return string.IsNullOrEmpty(name)
            //     ? "Hello, World!"
            //     : $"Hello, {CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name.ToLower())}!";

            // return string.IsNullOrEmpty(name)
            //     ? "Hello, World!"
            //     : $"Hello, {string.Concat(name.Select((c, i) => i == 0 ? char.ToUpper(c) : char.ToLower(c)))}!";
        }
    }
}