/*
https://www.codewars.com/kata/57fb4b289610ce39f70000de/csharp

7 kyu
Exclamation marks series #18: a simple slot machine that only contains exclamation marks and question marks

Description:
You are playing a simple slot machine that only contains exclamation marks and question marks. 
Every time the slot machine is started, a string of 5 length is obtained. 
If you're lucky enough to get a Special permutation, you'll win the bonus. 
Give you a string s, return the highest bonus.

Bouns list:

Five-of-a-Kind:   ---- 1000
"!!!!!" or "?????"

Four-of-a-Kind:    ---- 800
The string contains a "!!!!" or "????"
"!!!!?","?!!!!","????!","!????"

Full House:         ----500
such as "!!!??" or "???!!"...

Three-of-a-Kind:    ---- 300
The string contains a "!!!" or "???"
such as "!!!?!","!???!"...

Two pair:           ---- 200
The string contains two "!!" or "??"
such as "??!!?","!!?!!"

A Pair:             ---- 100
The string contains a "!!" or "??"
such as "?!??!","!!?!?"

Others              ---- 0
such as "?!?!?","!?!?!"
Examples
slot("!!!!!") === 1000
slot("!!!!?") === 800
slot("!!!??") === 500
slot("!!!?!") === 300
slot("!!?!!") === 200
slot("!!?!?") === 100
slot("!?!?!") === 0
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace CodeWars
{
    public class ExclamationMarksSeries18
    {
        public static int Slot(string s)
        {
            // var m = Regex.Matches(s, @"!+|\?+").Select(x => x.Value).OrderBy(x => -x.Length).ToArray();
            var m = Regex.Matches(s, @"!+|\?+").OrderBy(x => -x.Length).ToArray();

            return m.Length switch
            {
                1 => 1000,
                2 => m[0].Length == 4 ? 800 : 500,
                3 => m[0].Length == 3 ? 300 : 200,
                4 => 100,
                _ => 0
            };
        }
    }
}