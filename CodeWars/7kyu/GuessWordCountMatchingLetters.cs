/*
https://www.codewars.com/kata/5912ded3f9f87fd271000120/csharp

7 kyu
Guess the Word: Count Matching Letters

Consider a game, wherein the player has to guess a target word. All the player knows is the length of the target word.

To help them in their goal, the game will accept guesses, and return the number of letters that are in the correct position.

Write a method that, given the correct word and the player's guess, returns this number.

For example, here's a possible thought process for someone trying to guess the word "dog":

CountCorrectCharacters("dog", "car"); //0 (No letters are in the correct position)
CountCorrectCharacters("dog", "god"); //1 ("o")
CountCorrectCharacters("dog", "cog"); //2 ("o" and "g")
CountCorrectCharacters("dog", "cod"); //1 ("o")
CountCorrectCharacters("dog", "bog"); //2 ("o" and "g")
CountCorrectCharacters("dog", "dog"); //3 (Correct!)
The caller should ensure that the guessed word is always the same length as the correct word, 
but since it could cause problems if this were not the case, you need to check for this eventuality:

//Throw an InvalidOperationException if the two parameters are of different lengths.
You may assume, however, that the two parameters will always be in the same case.
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class GuessWordCountMatchingLetters
    {
        public int CountCorrectCharacters(string correctWord, string guess)
        {
            return correctWord.Length == guess.Length
                ? correctWord.Where((x, i) => x == guess[i]).Count()
                : throw new InvalidOperationException();

            // return correctWord.Length == guess.Length
            //     ? correctWord.Zip(guess, (x, y) => x == y).Count(x => x)
            //     : throw new InvalidOperationException();

            // return correctWord.Length == guess.Length
            //     ? correctWord.Zip(guess, (x, y) => x == y ? 1 : 0).Sum()
            //     : throw new InvalidOperationException();

            // return correctWord.Length == guess.Length
            //     ? Enumerable.Range(0, guess.Length).Count(i => guess[i] == correctWord[i])
            //     : throw new InvalidOperationException();
        }
    }
}