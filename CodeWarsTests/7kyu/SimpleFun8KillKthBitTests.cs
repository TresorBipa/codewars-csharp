using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun8KillKthBitTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun8KillKthBit();

            Assert.AreEqual(33, kata.KillKthBit(37, 3), "");

            Assert.AreEqual(37, kata.KillKthBit(37, 4), "");

            Assert.AreEqual(0, kata.KillKthBit(0, 4), "");

            Assert.AreEqual(2147450879, kata.KillKthBit(2147483647, 16), "");

            Assert.AreEqual(374819652, kata.KillKthBit(374823748, 13), "");

            Assert.AreEqual(1084197039, kata.KillKthBit(1084197039, 15), "");
        }
    }
}