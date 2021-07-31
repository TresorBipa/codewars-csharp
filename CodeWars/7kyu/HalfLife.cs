/*
https://www.codewars.com/kata/59f33b86a01431d5ae000032/csharp

7 kyu
Half Life

The half-life of a radioactive substance is the time it takes (on average) for one-half of its atoms to undergo radioactive decay.

Task Overview
Given the initial quantity of a radioactive substance, 
the quantity remaining after a given period of time, and the period of time, return the half life of that substance.

Usage Examples
// if quantity halves in 1 time period, half-life = 1
Kata.HalfLife(10, 5, 1) => 1
// if quantity halves in 2 time periods, half-life = 2
Kata.HalfLife(8,4,2) => 2
// if quantity is one-quarter after 2 time periods, half-life = 1
Kata.HalfLife(12,3,2) => 1
Documentation:
Kata.HalfLife Method (Double, Double, Int32)
Returns the half-life for a substance given the initial quantity, the remaining quantity, and the elasped time.

Syntax

public static double HalfLife(
double quantityInitial,
  double quantityRemaining,
int time
  )

Parameters
quantityInitial
Type: System.Double
The initial amount of the substance.

quantityRemaining
Type: System.Double
The current amount of the substance.

time
Type: System.Int32
The amount of time elapsed.

Return Value
Type: System.Double
A floating-point number representing the half-life of the substance.
*/

using System;

namespace CodeWars
{
    public class KataHalfLife
    {
        public static double HalfLife(double quantityInitial, double quantityRemaining, int time)
        {
            return time / Math.Log(quantityRemaining / quantityInitial, .5);
            // return time / Math.Log(quantityInitial / quantityRemaining, 2);
            // return time / Math.Log(quantityRemaining / quantityInitial, 0.5);
            // return time * Math.Log(2) / Math.Log(quantityInitial / quantityRemaining);
            // return (time * Math.Log(2)) / (Math.Log(quantityInitial) - Math.Log(quantityRemaining));
        }
    }
}