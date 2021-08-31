using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class MakeBackronymTests
    {
        [Test]
        public static void TestExample1()
        {
            Assert.AreEqual("ingestable newtonian turn eager rant eager stylish turn ingestable newtonian gregarious",
                KataMakeBackronym.MakeBackronym("interesting"));
        }

        [Test]
        public static void TestExample2()
        {
            Assert.AreEqual("confident oscillating disturbing eager weird awesome rant stylish",
                KataMakeBackronym.MakeBackronym("codewars"));
        }
    }
}