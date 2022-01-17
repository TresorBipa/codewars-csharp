/*
https://www.codewars.com/kata/5886f3713a111b620f0000dc/csharp

7 kyu
Simple Fun #28: Html End Tag By Start Tag

Task
You are implementing your own HTML editor. 
To make it more comfortable for developers you would like to add an auto-completion feature to it.

Given the starting HTML tag, find the appropriate end tag which your editor should propose.

Example
For startTag = "<button type='button' disabled>", the output should be "</button>";

For startTag = "<i>", the output should be "</i>".

Input/Output
[input] string startTag/start_tag

[output] a string
*/

using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class SimpleFun28HtmlEndTagByStartTag
    {
        public string HtmlEndTagByStartTag(string StartTag)
        {
            return "</" + Regex.Match(StartTag, @"\w+") + ">";
            // return "</" + StartTag.Split('<', ' ', '>')[1] + ">";
            // return $"</{Regex.Match(StartTag, "[a-z]+").Value}>";
            // return $"</{Regex.Match(StartTag, @"<([a-z]+)").Groups[1].Value}>";
            // return $"</{Regex.Match(StartTag, "^<([a-z]+)").Groups[1].Value}>";
            // return $"</{string.Concat(StartTag.Skip(1).TakeWhile(char.IsLetter))}>";
            // return Regex.Replace(Regex.Replace(StartTag, " .*?>", ">"), "^<", "</");
            // return "</" + StartTag.Split(' ').First().TrimEnd('>').Substring(1) + ">";
        }
    }
}