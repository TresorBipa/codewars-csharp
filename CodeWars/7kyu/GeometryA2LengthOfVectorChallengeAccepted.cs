/*
https://www.codewars.com/kata/554dc2b88fbafd2e95000125/csharp

7 kyu
[Geometry A-2]: Length of a vectorChallenge accepted

For a given 2D vector described by cartesian coordinates of its initial point and terminal point in the following format:

// Argument will be passed as a Vector2

public struct Vector2
{
  public Point2 Head;
  public Point2 Tail;

  public Vector2(Point2 tail, Point2 head)
  {
    this.Tail = tail;
    this.Head = head;
  }

  public Point2 this[int i]
  {
    get
    {
      return new Point2[] {this.Tail, this.Head}[i];
    }
  }
}

public struct Point2
{
  public double X;
  public double Y;

  public Point2(double x, double y)
  {
    this.X = x;
    this.Y = y;
  }

  public double this[int i]
  {
    get
    {
      return new double[] {this.X, this.Y}[i];
    }
  }
}
Your function must return this vector's length represented as a floating point number.

Error must be within 1e-7.

Coordinates can be integers or floating point numbers.
*/

using System;

//using System.Numerics;

namespace CodeWars
{
    public class GeometryA2LengthOfVectorChallengeAccepted
    {
        public struct Vector2
        {
            public Point2 Head;
            public Point2 Tail;

            public Vector2(Point2 tail, Point2 head)
            {
                this.Tail = tail;
                this.Head = head;
            }

            public Point2 this[int i]
            {
                get { return new Point2[] {this.Tail, this.Head}[i]; }
            }
        }

        public struct Point2
        {
            public double X;
            public double Y;

            public Point2(double x, double y)
            {
                this.X = x;
                this.Y = y;
            }

            public double this[int i]
            {
                get { return new double[] {this.X, this.Y}[i]; }
            }
        }

        public static double VectorLength(Vector2 vec)
        {
            //return Math.Sqrt(Math.Pow(vec[0][0] - vec[1][0], 2) + Math.Pow(vec[0][1] - vec[1][1], 2));
            //return Math.Sqrt(Math.Pow(vec.Tail.X - vec.Head.X, 2) + Math.Pow(vec.Tail.Y - vec.Head.Y, 2));

            var x = vec.Head.X - vec.Tail.X;
            var y = vec.Head.Y - vec.Tail.Y;
            return Math.Sqrt(x * x + y * y);
        }
    }
}