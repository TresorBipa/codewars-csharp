using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun194BinaryStringTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun194BinaryString();
            Assert.AreEqual(3, kata.BinStr("0101"));
            Assert.AreEqual(2, kata.BinStr("10000"));
            Assert.AreEqual(0, kata.BinStr("0000000000"));
            Assert.AreEqual(1, kata.BinStr("1111111111"));
            Assert.AreEqual(14, kata.BinStr("10101010101010"));
            Assert.AreEqual(3, kata.BinStr("11111000011111"));
            Assert.AreEqual(2, kata.BinStr("000001111100000"));
            Assert.AreEqual(2, kata.BinStr("111000000000"));
            Assert.AreEqual(1, kata.BinStr("00000000111111111"));
            Assert.AreEqual(10, kata.BinStr("1010101011111111111111000000000"));
        }
    }
}