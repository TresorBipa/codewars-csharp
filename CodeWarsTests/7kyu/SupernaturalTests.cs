using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SupernaturalTests
    {
        [Test]
        public static void FixedTest()
        {
            Assert.AreEqual("Behead it with a machete, idjits!", Supernatural.Bob("vampire"));
            Assert.AreEqual("It depends on which one it is, idjits!", Supernatural.Bob("pagan god"));
            Assert.AreEqual("I have friggin no idea yet, idjits!", Supernatural.Bob("werepuppy"));
        }
    }
}