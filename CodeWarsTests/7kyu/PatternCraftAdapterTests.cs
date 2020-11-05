using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class PatternCraftAdapterTests
    {
        [Test]
        public void _0_MarioAdapter_Can_Attack()
        {
            var marioAdapter = new PatternCraftAdapter(new Mario());
            var target = new Target {Health = 33};

            marioAdapter.Attack(target);

            Assert.AreEqual(30, target.Health);
        }
    }
}