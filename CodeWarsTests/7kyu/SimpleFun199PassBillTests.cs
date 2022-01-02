using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun199PassBillTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun199PassBill();
            Assert.AreEqual(2, kata.PassTheBill(8, 3, 3));
            Assert.AreEqual(-1, kata.PassTheBill(13, 4, 7));
            Assert.AreEqual(0, kata.PassTheBill(7, 4, 3));
            Assert.AreEqual(2, kata.PassTheBill(11, 4, 1));
            Assert.AreEqual(1, kata.PassTheBill(11, 5, 1));
            Assert.AreEqual(0, kata.PassTheBill(11, 6, 1));
            Assert.AreEqual(2, kata.PassTheBill(11, 4, 4));
            Assert.AreEqual(1, kata.PassTheBill(11, 5, 4));
            Assert.AreEqual(1, kata.PassTheBill(11, 5, 5));
            Assert.AreEqual(-1, kata.PassTheBill(11, 4, 6));
            Assert.AreEqual(2, kata.PassTheBill(11, 4, 5));
            Assert.AreEqual(0, kata.PassTheBill(15, 9, 3));
        }
    }
}