/*
https://www.codewars.com/kata/switch-it-up/csharp
https://www.codewars.com/kata/5808dcb8f0ed42ae34000031/csharp

8 kyu
Switch it Up!

When provided with a number between 0-9, return it in words.

Input :: 1
Output :: "One".
If your language supports it, try using a switch statement.
*/

using System.Collections.Generic;

namespace CodeWars
{
    public class KataSwitchItUp
    {
        public static string SwitchItUp(int number) =>
            number switch
            {
                0 => "Zero",
                1 => "One",
                2 => "Two",
                3 => "Three",
                4 => "Four",
                5 => "Five",
                6 => "Six",
                7 => "Seven",
                8 => "Eight",
                9 => "Nine",
                _ => ""
            };


        //public static string SwitchItUp(int number)
        //{
        //    var dic = new Dictionary<int, string>()
        //    {
        //        {1, "One"},
        //        {2, "Two"},
        //        {3, "Three"},
        //        {4, "Four"},
        //        {5, "Five"},
        //        {6, "Six"},
        //        {7, "Seven"},
        //        {8, "Eight"},
        //        {9, "Nine"},
        //        {0, "Zero"}      
        //    };
        //    return dic[number];
        //}

        //public static string SwitchItUp(int number)
        //{
        //    string[] numbers =
        //        { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten" };

        //    return numbers[number];
        //}


        //public static string SwitchItUp(int number)
        //{
        //    return  new[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine"}[number];
        //}


        //public static string SwitchItUp(int number)
        //{
        //    return new Dictionary<int, string> {{ 1, "One" },
        //        { 2, "Two"},
        //        { 3, "Three"},
        //        { 4, "Four"},
        //        { 5, "Five"},
        //        { 6, "Six"},
        //        { 7, "Seven"},
        //        { 8, "Eight"},
        //        { 9, "Nine"},
        //        { 0, "Zero"}}[number];
        //}


        //enum Digit{Zero,One,Two,Three,Four,Five,Six,Seven,Eight,Nine}

        //public static string SwitchItUp(int number)
        //{
        //    return ((Digit)number).ToString();
        //}





    }
}