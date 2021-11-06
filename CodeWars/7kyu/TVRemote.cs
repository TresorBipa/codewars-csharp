/*
https://www.codewars.com/kata/5a5032f4fd56cb958e00007a/csharp

7 kyu
TV Remote

Background
My TV remote control has arrow buttons and an OK button.

I can use these to move a "cursor" on a logical screen keyboard to type "words"...

The screen "keyboard" layout looks like this

a	b	c	d	e	1	2	3
f	g	h	i	j	4	5	6
k	l	m	n	o	7	8	9
p	q	r	s	t	.	@	0
u	v	w	x	y	z	_	/
Kata task
How many button presses on my remote are required to type a given word?

Notes
The cursor always starts on the letter a (top left)
Remember to also press OK to "accept" each character.
Take a direct route from one character to the next
The cursor does not wrap (e.g. you cannot leave one edge and reappear on the opposite edge)
A "word" (for the purpose of this Kata) is any sequence of characters available on my virtual "keyboard"
Example
word = codewars

c => a-b-c-OK = 3
o => c-d-e-j-o-OK = 5
d => o-j-e-d-OK = 4
e => d-e-OK = 2
w => e-j-o-t-y-x-w-OK = 7
a => w-r-m-h-c-b-a-OK = 7
r => a-f-k-p-q-r-OK = 6
s => r-s-OK = 2
Answer = 3 + 5 + 4 + 2 + 7 + 7 + 6 + 2 = 36

*Good Luck!
DM.*
Series

TV Remote
TV Remote (shift and space)
TV Remote (wrap)
TV Remote (symbols)
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class KataTVRemote
    {
        public static int TvRemote(string word)
        {
            const string keyboard = "abcde123fghij456klmno789pqrst.@0uvwxyz_/";

            var moves = 0;
            var pos = 0;

            foreach (var index in word.Select(c => keyboard.IndexOf(c)))
            {
                moves += Math.Abs(pos % 8 - index % 8) + Math.Abs(pos / 8 - index / 8) + 1;
                pos = index;
            }

            return moves;


            // int moves = 0, x = 0, y = 0;
            // foreach (var index in word.Select(c => "abcde123fghij456klmno789pqrst.@0uvwxyz_/".IndexOf(c)))
            // {
            //     moves += Math.Abs(x - index % 8) + Math.Abs(y - index / 8) + 1;
            //     x = index % 8;
            //     y = index / 8;
            // }
            //
            // return moves;


            // return word.Select(x => "abcde123fghij456klmno789pqrst.@0uvwxyz_/".IndexOf(x))
            //     .Aggregate((pos: 0, index: 0),
            //         (a, b) => (++a.pos + Math.Abs(a.index / 8 - b / 8) + Math.Abs(a.index % 8 - b % 8), b))
            //     .pos;
        }
    }
}