/*
https://www.codewars.com/kata/5cb7baa989b1c50014a53333/csharp

7 kyu
Is Sator Square?

A Discovery
While turning through the fields one fine day with his favorite rotary plough, 
farmer Arepo struck upon something quite odd: a square stone tablet with strange symbols carved into it... 
he knew some such objects could portray the same message in four different directions all at once, 
so he wisely kept it for later examination and dutifully resumed working the rich soil. 
As he wheeled on, he found more such tablets, but with so many crops to sow, 
he had no time for deciphering their many glyphs.

Your Task
Please help Arepo by reading each tablet to discern whether or not it is a Sator Square!

The Square . . .
is known as a two-dimentional palindrome observing four symmetries

can be read:

top-to-bottom
bottom-to-top
left-to-right
right-to-left
can be rotated 180 degrees and still be read in all four ways

may contain similar looking characters that are different, so be careful

is shown here illustrates how you can read the word "TUBA" in four different directions...

          v
      B A T S
      A B U T <
    > T U B A        
      S T A B
        ^
...where every word in the square can be thus read!

Input
public static bool IsSatorSquare(char[,] Tablet)
//  a two-dimentional array of characters (2 <= n <= 33)
Output
true or false  //  whether or not the tablet is a sator square
Enjoy!
If interested, you may choose from one of the following kata to solve next:

Playing With Toy Blocks ~ Can you build a 4x4 square?
Four Letter Words ~ Mutations
Crossword Puzzle! (2x2)
*/

using System.Linq;

namespace CodeWars
{
    public class KataIsSatorSquare
    {
        public static bool IsSatorSquare(char[,] tablet)
        {
            return !Enumerable.Range(0, tablet.GetLength(0)).Select(i =>
                    Enumerable.Range(0, tablet.GetLength(0)).Select(j =>
                        tablet[i, j] != tablet[j, i] ||
                        tablet[i, j] != tablet[tablet.GetLength(0) - i - 1, tablet.GetLength(0) - j - 1]))
                .Any(x => x.Any(b => b));


            // for (int i = 0; i < n; i++)
            // {
            //     for (int j = 0; j < n; j++)
            //     {
            //         if (tablet[i, j] != tablet[j, i] || tablet[i, j] != tablet[n - i - 1, n - j - 1]) return false;
            //     }
            // }
            //
            // return true;
        }
    }
}