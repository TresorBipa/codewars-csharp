/*
https://www.codewars.com/kata/58aa9662c55ffbdceb000101/csharp

7 kyu
Simple Fun #149: Next Day Of Week

Task
You have set an alarm for some of the week days.

Days of the week are encoded in binary representation like this:

0000001 - Sunday
0000010 - Monday
0000100 - Tuesday
0001000 - Wednesday
0010000 - Thursday
0100000 - Friday 
1000000 - Saturday```
For example, if your alarm is set only for Sunday and Friday, the representation will be `0100001`. 

 Given the current day of the week, your task is to find the day of the week when alarm will ring next time.

# Example

 For `currentDay = 4, availableWeekDays = 42`, the result should be `6`.
currentDay = 4 means the current Day is Wednesday availableWeekDays = 42 convert to binary is "0101010" So the next day is 6 (Friday)

```

Input/Output
[input] integer currentDay

The weekdays range from 1 to 7, 1 is Sunday and 7 is Saturday

[input] integer availableWeekDays

An integer. Days of the week are encoded in its binary representation.

[output] an integer

The next day available.

*/

using System;
using System.Linq;

namespace CodeWars
{
    public class SimpleFun149NextDayOfWeek
    {
        public int NextDayOfWeek(int CurrentDay, int AvailableWeekDays)
        {
            // string days = Convert.ToString(AvailableWeekDays, 2).PadLeft(7);
            // int i = days.Substring(0, 7 - CurrentDay).LastIndexOf('1');
            // if (i < 0) i = days.LastIndexOf('1');
            // return 7 - i;


            // int c = CurrentDay;
            // int n = (AvailableWeekDays << 7 | AvailableWeekDays) >> CurrentDay;
            // while ((n & 1) == 0)
            // {
            //     n >>= 1;
            //     c++;
            // }
            // return c % 7 + 1;


            return (Convert.ToString((AvailableWeekDays << 7) + AvailableWeekDays, 2).Reverse().Skip(CurrentDay)
                        .TakeWhile(c => c == '0').Count() +
                    CurrentDay) % 7 + 1;
        }
    }
}