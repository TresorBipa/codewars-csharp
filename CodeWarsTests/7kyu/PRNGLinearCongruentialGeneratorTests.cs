using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class PRNGLinearCongruentialGeneratorTests
    {
        [Test]
        public void DescriptionExampleTests()
        {
            PRNGLinearCongruentialGenerator myLCG = new PRNGLinearCongruentialGenerator(5);
            Assert.That(myLCG.Random(), Is.EqualTo(0.3).Within(1e-12));
            Assert.That(myLCG.Random(), Is.EqualTo(0.9).Within(1e-12));
            Assert.That(myLCG.Random(), Is.EqualTo(0.1).Within(1e-12));
            Assert.That(myLCG.Random(), Is.EqualTo(0.5).Within(1e-12));
        }
    }
}