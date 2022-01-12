using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class CasinoChipsTests
    {
        [Test]
        public void ExampleTests()
        {
            Assert.AreEqual(1, CasinoChips.solve(new int[] {1, 1, 1}));
            Assert.AreEqual(2, CasinoChips.solve(new int[] {1, 2, 1}));
            Assert.AreEqual(2, CasinoChips.solve(new int[] {4, 1, 1}));
            Assert.AreEqual(9, CasinoChips.solve(new int[] {8, 2, 8}));
            Assert.AreEqual(5, CasinoChips.solve(new int[] {8, 1, 4}));
            Assert.AreEqual(10, CasinoChips.solve(new int[] {7, 4, 10}));
            Assert.AreEqual(18, CasinoChips.solve(new int[] {12, 12, 12}));
            Assert.AreEqual(3, CasinoChips.solve(new int[] {1, 23, 2}));
        }
    }
}