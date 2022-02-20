using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun6IsInfiniteProcessTests
    {
        [Test]
        public void TestCase()
        {
            var kata = new SimpleFun6IsInfiniteProcess();
            Assert.AreEqual(false, kata.IsInfiniteProcess(2, 6), "");
            Assert.AreEqual(true, kata.IsInfiniteProcess(2, 3), "");
            Assert.AreEqual(false, kata.IsInfiniteProcess(2, 10), "");
            Assert.AreEqual(true, kata.IsInfiniteProcess(0, 1), "");
            Assert.AreEqual(true, kata.IsInfiniteProcess(3, 1), "");
            Assert.AreEqual(false, kata.IsInfiniteProcess(10, 10), "");
            Assert.AreEqual(true, kata.IsInfiniteProcess(5, 10), "");
        }
    }
}