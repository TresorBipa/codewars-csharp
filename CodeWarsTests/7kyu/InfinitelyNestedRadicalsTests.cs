using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class InfinitelyNestedRadicalsTests
    {
        [Test]
        public void testbasic()
        {
            Assert.AreEqual(2.0, InfinitelyNestedRadicals.evaluateFunction(2), 0.000000001);
            Assert.AreEqual(3.0, InfinitelyNestedRadicals.evaluateFunction(6), 0.000000001);
            Assert.AreEqual(4.0, InfinitelyNestedRadicals.evaluateFunction(12), 0.000000001);
        }
    }
}