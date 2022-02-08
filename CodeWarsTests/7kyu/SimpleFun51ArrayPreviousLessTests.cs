using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun51ArrayPreviousLessTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun51ArrayPreviousLess();

            Assert.AreEqual(new int[] {-1, 3, -1, 2, 4}, kata.ArrayPreviousLess(new int[] {3, 5, 2, 4, 5}));

            Assert.AreEqual(new int[] {-1, -1, -1, 1, 3, 4, 4, 1},
                kata.ArrayPreviousLess(new int[] {2, 2, 1, 3, 4, 5, 5, 3}));

            Assert.AreEqual(new int[] {-1, -1, -1}, kata.ArrayPreviousLess(new int[] {3, 2, 1}));
        }
    }
}