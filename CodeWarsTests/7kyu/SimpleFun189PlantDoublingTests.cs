using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun189PlantDoublingTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun189PlantDoubling();
            Assert.AreEqual(2, kata.PlantDoubling(5));
            Assert.AreEqual(1, kata.PlantDoubling(8));
            Assert.AreEqual(29, kata.PlantDoubling(536870911));
            Assert.AreEqual(1, kata.PlantDoubling(1));
        }
    }
}