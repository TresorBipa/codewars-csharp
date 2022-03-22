/*
https://www.codewars.com/kata/56548dad6dae7b8756000037/csharp

6 kyu
Clock in Mirror

Peter can see a clock in the mirror from the place he sits in the office. When he saw the clock shows 12:22

1
2
3
4
5
6
7
8
9
10
11
12
He knows that the time is 11:38

1
2
3
4
5
6
7
8
9
10
11
12

in the same manner:
05:25 --> 06:35
01:50 --> 10:10
11:58 --> 12:02
12:01 --> 11:59

Please complete the function WhatIsTheTime(timeInMirror), where timeInMirror is the mirrored time (what Peter sees) as string.

Return the real time as a string.
Consider hours to be between 1 <= hour < 13.
So there is no 00:20, instead it is 12:20.
There is no 13:20, instead it is 01:20.
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace CodeWars
{
    public class ClockInMirror
    {
        public static string WhatIsTheTime(string timeInMirror)
        {
            // return DateTime.Parse("12:00").Subtract(TimeSpan.Parse(timeInMirror)).ToString("hh:mm");
            // return (DateTime.Parse("00:00") - DateTime.Parse(timeInMirror).TimeOfDay).ToString("hh:mm");

            var time = timeInMirror.Split(':').Select(int.Parse).ToArray();
            var hh = 12 - time[0];
            var mm = (60 - time[1]) % 60;
            if (mm != 0) --hh;
            if (hh <= 0) hh += 12;
            return $"{hh:00}:{mm:00}";


            // var time = timeInMirror.Split(':').Select(int.Parse).ToArray();
            // var h = time[0];
            // var m = time[1];
            //
            // int hc;
            // int mc;
            //
            // if (h == 12 & m == 00)
            // {
            //     hc = h;
            //     mc = m;
            // }
            // else
            // {
            //     hc = 11 - h;
            //     mc = 60 - m;
            // }
            //
            // if (h == 12 & m != 0)
            // {
            //     hc = 12 - (13 - h);
            //     mc = 60 - m;
            // }
            //
            // if (m == 00)
            // {
            //     hc = 12 - h;
            //     mc = m;
            // }
            //
            // return Convert.ToDateTime(hc + ":" + mc).ToString("hh:mm");
        }
    }
}