using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class MOD256WithoutMODOperatorTests
    {
        [Test]
        public void ExampleTests()
        {
            Assert.AreEqual(254, MOD256WithoutMODOperator.Mod256WithoutMod(254));
            Assert.AreEqual(0, MOD256WithoutMODOperator.Mod256WithoutMod(256));
            Assert.AreEqual(2, MOD256WithoutMODOperator.Mod256WithoutMod(258));

            Assert.AreEqual(-254, MOD256WithoutMODOperator.Mod256WithoutMod(-254));
            Assert.AreEqual(0, MOD256WithoutMODOperator.Mod256WithoutMod(-256));
            Assert.AreEqual(-2, MOD256WithoutMODOperator.Mod256WithoutMod(-258));
        }
    }
}