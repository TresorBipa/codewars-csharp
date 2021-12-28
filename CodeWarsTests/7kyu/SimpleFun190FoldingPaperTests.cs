using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun190FoldingPaperTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun190FoldingPaper();

            Assert.AreEqual(2, kata.Folding(2, 1));

            Assert.AreEqual(6, kata.Folding(10, 7));

            Assert.AreEqual(3, kata.Folding(3, 1));

            Assert.AreEqual(4, kata.Folding(4, 1));

            Assert.AreEqual(3, kata.Folding(3, 2));

            Assert.AreEqual(2, kata.Folding(4, 2));

            Assert.AreEqual(6, kata.Folding(1000, 700));

            Assert.AreEqual(1000, kata.Folding(1000, 999));
        }
    }
}