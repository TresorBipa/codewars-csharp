/*
https://www.codewars.com/kata/57eaec5608fed543d6000021/csharp

7 kyu
Divide and Conquer

Given a mixed array of number and string representations of integers, 
add up the string integers and subtract this from the total of the non-string integers.

Return as a number.
*/


using System.Linq;

namespace CodeWars;

public class DivideAndConquer
{
    public static int DivCon(object[] objArray)
    {
        return objArray.Sum(o => (o is int ? 1 : -1) * int.Parse(o.ToString()));

        // var s = 0;
        // foreach (var o in objArray)
        // {
        //     if (o is int)
        //     {
        //         s += int.Parse(o.ToString()!);
        //     }
        //     else
        //     {
        //         s -= int.Parse(o.ToString()!);
        //     }
        // }
        //
        // return s;


        // foreach (var o in obj)
        // {
        //     if (o.GetType() == typeof(int))
        //     {
        //         s += int.Parse(o.ToString()!);
        //     }
        //     else
        //     {
        //         s -= int.Parse(o.ToString()!);
        //     }
        // }
        //
        // return s;
    }
}