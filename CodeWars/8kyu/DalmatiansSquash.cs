/*
https://www.codewars.com/kata/56f6919a6b88de18ff000b36/csharp

8 kyu
101 Dalmatians - squash the bugs, not the dogs!

Your friend has been out shopping for puppies (what a time to be alive!)... 
He arrives back with multiple dogs, and you simply do not know how to respond!
By repairing the function provided, you will find out exactly how you should respond, depending on the number of dogs he has.
The number of dogs will always be a number and there will always be at least 1 dog.
Good luck!
*/


namespace CodeWars._8kyu;

public static class DalmatiansSquash
{
    public static string HowManyDalmatians(int n)
    {
        return n switch
        {
            <= 10 => "Hardly any",
            <= 50 => "More than a handful!",
            _ => n == 101 ? "101 DALMATIONS!!!" : "Woah that's a lot of dogs!"
        };
    }
}