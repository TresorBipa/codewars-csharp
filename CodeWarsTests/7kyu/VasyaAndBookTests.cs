using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class VasyaAndBookTests
    {
        [Test]
        public void Test1()
        {
            int[] days = new int[] {15, 20, 20, 15, 10, 30, 45};
            int pages = 100;
            Assert.AreEqual(6, VasyaAndBook.DayIs(pages, days));
        }

        [Test]
        public void Test2()
        {
            int[] days = new int[] {1, 0, 0, 0, 0, 0, 0};
            int pages = 2;
            Assert.AreEqual(1, VasyaAndBook.DayIs(pages, days));
        }
    }
}