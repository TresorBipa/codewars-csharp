using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class WeIrDStRiNgCaSeTests
    {
        [Test]
        public static void ShouldWorkForSomeExamples()
        {
            Assert.AreEqual("ThIs", WeIrDStRiNgCaSe.ToWeirdCase("This"));
            Assert.AreEqual("Is", WeIrDStRiNgCaSe.ToWeirdCase("is"));
            Assert.AreEqual("ThIs Is A TeSt", WeIrDStRiNgCaSe.ToWeirdCase("This is a test"));
        }
    }
}