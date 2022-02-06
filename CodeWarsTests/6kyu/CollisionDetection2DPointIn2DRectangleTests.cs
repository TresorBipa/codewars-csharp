using System;
using CodeWars._6kyu;
using NUnit.Framework;

namespace CodeWarsTests._6kyu
{
    [TestFixture]
    public class CollisionDetection2DPointIn2DRectangleTests
    {
            [Test, Description("Testing for collision with unrotated rectangle")]
            public static void FixedRectangle()
            {
              // Simple, unrotated rectangle test
              Rectangle2 r;
              Point2 p;
              r = new Rectangle2(0f, 10f, 8f, new Point2(1f, 1f));
              p = new Point2(-6f, -6f);
              Assert.That(r.HasCollided(p), Is.False, "(-6f, -6f) is not contained within the rectangle.");
              
              p = new Point2(-3.5f, 4.5f);
              Assert.That(r.HasCollided(p), Is.True, "(-3.5f, 4.5f) is contained within the rectangle.");
              
              // Points which belong to a bounding line are not considered to have "collided" with the Rectangle
              p = new Point2(-3.5f, 5.0f);
              Assert.That(r.HasCollided(p), Is.False, "(-3.5f, 5.0f) is not contained within the rectangle.");
            }
            
            [Test, Description("Testing for collision with rotated rectangle")]
            public static void RotatedRectangle()
            {
              Rectangle2 r;
              Point2 p;
              r = new Rectangle2((float)(45 * (Math.PI / 180.0f)), 4f, 6f, new Point2(2f, 3f));
              p = new Point2(-1f, 4f);
              Assert.That(r.HasCollided(p), Is.False, "(-1f, 4f) is not contained within the rectangle.");
              
              p = new Point2(0.5f, 5f);
              Assert.That(r.HasCollided(p), Is.False, "(0.5f, 5f) is not contained within the rectangle.");
              
              p = new Point2(1.5f, 5.5f);
              Assert.That(r.HasCollided(p), Is.False, "(1.5f, 5.5f) is not contained within the rectangle.");
              
              p = new Point2(-1, 2.5f);
              Assert.That(r.HasCollided(p), Is.True, "(-1, 2.5f) is contained within the rectangle.");
              
              p = new Point2(2.5f, 6.2f);
              Assert.That(r.HasCollided(p), Is.True, "(2.5f, 6.2f) is contained within the rectangle.");
            }
    }
}