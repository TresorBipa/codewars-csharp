using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class MagicSquareValidatorTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(true, MagicSquareValidator.IsMagical(new int[] {4, 9, 2, 3, 5, 7, 8, 1, 6}),
                "This is a valid magic square.");
            Assert.AreEqual(false, MagicSquareValidator.IsMagical(new int[] {4, 9, 2, 3, 5, 7, 8, 6, 1}),
                "Some column(s) and diagonal(s) don't sum to 15");
            Assert.AreEqual(false, MagicSquareValidator.IsMagical(new int[] {4, 5, 2, 3, 9, 7, 8, 1, 6}),
                "Some row(s) don't sum to 15");
        }
    }
}