using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class IPv4ValidatorTests
    {
        [TestCase("123.456.789.0", false)]
        [TestCase("127.0.0.1", true)]
        public void IpValidatorTest(string ip, bool isValid)
        {
            Assert.AreEqual(isValid, IPv4Validator.IpValidator(ip));
        }
    }
}