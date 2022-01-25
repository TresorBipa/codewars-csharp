using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun39SwitchLightsTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun39SwitchLights();

            Assert.AreEqual(new int[] {0, 1, 0, 1, 0}, kata.SwitchLights(new int[] {1, 1, 1, 1, 1}));

            Assert.AreEqual(new int[] {0, 0}, kata.SwitchLights(new int[] {0, 0}));

            Assert.AreEqual(new int[] {1, 1, 1, 0, 0, 1, 1, 0}, kata.SwitchLights(new int[] {1, 0, 0, 1, 0, 1, 0, 1}));

            Assert.AreEqual(new int[] {1, 1, 1, 1, 1, 0, 1, 0, 0, 0, 1, 1, 0},
                kata.SwitchLights(new int[] {1, 0, 0, 0, 0, 1, 1, 1, 0, 0, 1, 0, 1}));
        }
    }
}