using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun67ArrayChangeTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun67ArrayChange();

            Assert.AreEqual(3, kata.ArrayChange(new int[] {1, 1, 1}));

            Assert.AreEqual(5, kata.ArrayChange(new int[] {-1000, 0, -2, 0}));

            Assert.AreEqual(12, kata.ArrayChange(new int[] {2, 1, 10, 1}));

            Assert.AreEqual(13, kata.ArrayChange(new int[] {2, 3, 3, 5, 5, 5, 4, 12, 12, 10, 15}));
        }
    }
}