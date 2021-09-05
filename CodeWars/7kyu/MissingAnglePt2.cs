/*
https://www.codewars.com/kata/58e4f4ab020336dc4500093c/csharp

7 kyu
Missing Angle Pt. 2

Below is a triangle:

       / \
      /   \
  a  /     \  c
    /       \
   /       θ \
  /___________\
        b     

Your challange is to write a function that returns the size of angle θ in degrees to 1 decimal place. 
You will be given three arguments representing each side: a, b and c. 
Again, you will not be expected to handle any erronous data in your solution.
*/

using System;

namespace CodeWars
{
    public class MissingAnglePt2
    {
        public static double missingAngle(double a, double b, double c)
        {
            // double theta = Math.Acos((b * b + c * c - a * a) / (2 * b * c));
            // return Math.Round(theta * 180.0 / Math.PI, 1);


            // return Math.Round(
            //     Math.Acos(((Math.Pow(b, 2) + Math.Pow(c, 2)) - Math.Pow(a, 2)) / (2 * b * c)) * (180 / Math.PI), 1);


            // return Math.Round(
            //     Math.Acos((-0.5 * Math.Pow(a, 2) + 0.5 * Math.Pow(b, 2) + 0.5 * Math.Pow(c, 2)) / (b * c)) *
            //     (180 / Math.PI), 1);


            // double cosinusTheta = (b * b + c * c - a * a) / (2 * b * c);
            // double theta = Math.Round((Math.Acos(cosinusTheta) * 180 / Math.PI), 1);
            // return theta;


            // return Math.Round(Math.Acos((c * c + b * b - a * a) / (2.0 * b * c)) * (180.0 / Math.PI), 1);
            // return Math.Round((180 * Math.Acos((a * a - b * b - c * c) / (-2 * b * c))) / Math.PI, 1);
            // return Math.Round(Math.Acos((b * b + c * c - a * a) / (2 * b * c)) * 1800 / Math.PI) / 10;
            // return Math.Round(Math.Acos((a * a - b * b - c * c) / (-2 * b * c)) * (180 / Math.PI), 1);
            return Math.Round(Math.Acos((c * c + b * b - a * a) / (2 * b * c)) * 180 / Math.PI, 1);
        }
    }
}