using CodeWars._6kyu;
using NUnit.Framework;

namespace CodeWarsTests._6kyu
{
    [TestFixture]
    public class KataAreaOfPolygonInsideCircleTests
    {
        [Test]
        public void ExampleTests()
        {
            Assert.AreEqual(11.691, KataAreaOfPolygonInsideCircle.AreaOfPolygonInsideCircle(3, 3));
            Assert.AreEqual(8, KataAreaOfPolygonInsideCircle.AreaOfPolygonInsideCircle(2, 4));
            Assert.AreEqual(14.86, KataAreaOfPolygonInsideCircle.AreaOfPolygonInsideCircle(2.5, 5));
        }
    }
}