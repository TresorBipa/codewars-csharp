using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class FixMyPhoneNumbersTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("02078834982", FixMyPhoneNumbers.IsItANum("S:)0207ERGQREG88349F82!efRF)"));
            Assert.AreEqual("Not a phone number", FixMyPhoneNumbers.IsItANum("sjfniebienvr12312312312ehfWh"));
            Assert.AreEqual("Not a phone number", FixMyPhoneNumbers.IsItANum("0192387415456"));
            Assert.AreEqual("02084564165", FixMyPhoneNumbers.IsItANum("v   uf  f 0tt2eg qe0b 8rtyq4eyq564()(((((165"));
            Assert.AreEqual("Not a phone number",
                FixMyPhoneNumbers.IsItANum("stop calling me no I have never been in an accident"));
        }
    }
}