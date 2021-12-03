using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun124LampsTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun124Lamps();

            Assert.AreEqual(5, kata.Lamps(new int[] {1, 0, 0, 1, 0, 1, 0, 0, 1, 0, 1}));

            Assert.AreEqual(6, kata.Lamps(new int[] {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1}));

            Assert.AreEqual(0, kata.Lamps(new int[] {1, 0, 1}));

            Assert.AreEqual(0, kata.Lamps(new int[] {1, 0, 1, 0}));

            Assert.AreEqual(0, kata.Lamps(new int[] {0, 1, 0, 1, 0}));

            Assert.AreEqual(4, kata.Lamps(new int[] {1, 0, 1, 0, 0, 1, 0, 1}));

            Assert.AreEqual(5, kata.Lamps(new int[] {1, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0}));
        }
    }
}