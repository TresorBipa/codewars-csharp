using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun9ArrayPackingTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun9ArrayPacking();

            Assert.AreEqual(21784, kata.ArrayPacking(new int[] {24, 85, 0}), "");

            Assert.AreEqual(2567447, kata.ArrayPacking(new int[] {23, 45, 39}), "");
        }
    }
}