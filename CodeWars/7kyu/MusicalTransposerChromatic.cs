/*
https://www.codewars.com/kata/59bda06acb7fb43a94000036/csharp

7 kyu
Musical Transposer - Chromatic

One afternoon you are playing music on your MIDI keyboard, when you decide to write a program that will harmonize with your melody. 
For every note you play, the harmony will transpose it a given number of semi-tones. For example, if you play the note C, 
with a transposition of 1, the harmony will play C#. If you play the note A, with a transposition of 7, the harmony will play E. 
For this excercise, the transposition will not exceed an octave (12 semi-tones), but if the value is negative, you will have to transpose down. 
To keep things simple, enharmonic spellings will be limited to sharps and naturals.

Possible notes: "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B", ("C")

Possible transpositions: any integer between -12 and 12 (inclusive)
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class MusicalTransposerChromatic
    {
        public static string Transpose(string noteName, int transposition)
        {
            // string[] notes = {"C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B"};
            // return notes[(12 + transposition + Array.IndexOf(notes, noteName)) % 12];

            var notes = new List<string> {"C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B"};
            return notes[(12 + transposition + notes.IndexOf(noteName)) % 12];
        }
    }
}