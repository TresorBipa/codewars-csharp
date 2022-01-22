using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun384IsTuringsEquationTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.That(SimpleFun384IsTuringsEquation.IsTuringEquation("73+42=16"), Is.EqualTo(true));
            Assert.That(SimpleFun384IsTuringsEquation.IsTuringEquation("5+8=13"), Is.EqualTo(false));
            Assert.That(SimpleFun384IsTuringsEquation.IsTuringEquation("10+20=30"), Is.EqualTo(true));
            Assert.That(SimpleFun384IsTuringsEquation.IsTuringEquation("0001000+000200=00030"), Is.EqualTo(true));
            Assert.That(SimpleFun384IsTuringsEquation.IsTuringEquation("1234+5=1239"), Is.EqualTo(false));
            Assert.That(SimpleFun384IsTuringsEquation.IsTuringEquation("1+0=0"), Is.EqualTo(false));
            Assert.That(SimpleFun384IsTuringsEquation.IsTuringEquation("7000+8000=51"), Is.EqualTo(true));
            Assert.That(SimpleFun384IsTuringsEquation.IsTuringEquation("0+0=0"), Is.EqualTo(true));
        }
    }
}