using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class TurnAnyWordIntoBeefTacoTests
    {
        [Test]
        public void BasicTest()
        {
            Assert.AreEqual(new string[] { "shell", "shell" }, TurnAnyWordIntoBeefTaco.Tacofy(""));
            Assert.AreEqual(new string[] { "shell", "beef", "shell" }, TurnAnyWordIntoBeefTaco.Tacofy("a"));
            Assert.AreEqual(new string[] { "shell", "guacamole", "guacamole", "guacamole", "shell" },
                TurnAnyWordIntoBeefTaco.Tacofy("ggg"));
            Assert.AreEqual(new string[] { "shell", "beef", "guacamole", "lettuce", "shell" },
                TurnAnyWordIntoBeefTaco.Tacofy("ogl"));
            Assert.AreEqual(new string[] { "shell", "tomato", "beef", "shell" },
                TurnAnyWordIntoBeefTaco.Tacofy("ydjkpwqrzto"));
        }
    }
}