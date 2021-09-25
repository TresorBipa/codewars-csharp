﻿/*
https://www.codewars.com/kata/training-js-number-7-if-dot-else-and-ternary-operator/csharp
https://www.codewars.com/kata/57202aefe8d6c514300001fd/csharp

8 kyu
Training JS #7: if..else and ternary operator

*/


namespace CodeWars
{
    public class TrainingJS7
    {
        public static int SaleHotDogs(int n)
        {
            return n * (n < 5 ? 100 : n < 10 ? 95 : 90);
        }
    }
}