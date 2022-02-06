/*
https://www.codewars.com/kata/5bc2c578a10a5b0b97000063/csharp

6 kyu
Collision Detection - 2D Point in 2D Rectangle

Overview
Collision detection is an important mechanic in many applications, specifically in the field of game development. 
For example, detecting when a player enters some sort of bounding box may be useful to trigger certain events.

For the purpose of this Kata, 
the user will be asked to create an algorithm which detects if a point in 2D space is contained within a 2D rectangle. 
A point which is on the edge of the rectangle is not considered a collision.

Technical Information
Points are made up of an X and Y coordinate.

Rectangles consist of rotation information (clockwise, in radians), 
the X width, the Y width, and a Point representing the center of the rectangle.

Source code:

using System;

namespace Kata
{
  public struct Point2
  {
    public float X;
    public float Y;
    
    public Point2(float pX, float pY)
    {
      this.X = pX;
      this.Y = pY;
    }
    
    public static Point2 operator-(Point2 p1, Point2 p2)
    {
      return new Point2(p1.X - p2.X, p1.Y - p2.Y);
    }
    
    public static Point2 operator+(Point2 p1, Point2 p2)
    {
      return new Point2(p1.X + p2.X, p1.Y + p2.Y);
    }
  }

  public class Rectangle2
  {
    public float Rotation;
    public float WidthX;
    public float WidthY;
    public Point2 Position;
  
    public Rectangle2(float pR, float pWX, float pWY, Point2 pP)
    {
      this.Rotation = pR;
      this.WidthX = pWX;
      this.WidthY = pWY;
      this.Position = pP;
    }
  }
}
Explanatory diagram:

Diagram
*/


using System;

namespace CodeWars._6kyu
{
    public struct Point2
    {
        public float X;
        public float Y;

        public Point2(float pX, float pY)
        {
            X = pX;
            Y = pY;
        }

        public static Point2 operator -(Point2 p1, Point2 p2) => new Point2(p1.X - p2.X, p1.Y - p2.Y);
        public static Point2 operator +(Point2 p1, Point2 p2) => new Point2(p1.X + p2.X, p1.Y + p2.Y);
    }

    public class Rectangle2
    {
        public float Rotation;
        public float WidthX;
        public float WidthY;
        public Point2 Position;

        public Rectangle2(float pR, float pWX, float pWY, Point2 pP)
        {
            Rotation = pR;
            WidthX = pWX;
            WidthY = pWY;
            Position = pP;
        }
    }

    public static class CollisionDetection2DPointIn2DRectangle
    {
        public static bool HasCollided(this Rectangle2 r, Point2 p)
        {
            var an = r.Rotation + Math.Atan2(p.Y -= r.Position.Y, p.X -= r.Position.X);
            var rt = Math.Sqrt(p.X * p.X + p.Y * p.Y) * 2;
            return r.WidthY > Math.Abs(rt * Math.Sin(an)) && r.WidthX > Math.Abs(rt * Math.Cos(an));
        }
    }
}