using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class PatternCraftVisitorTests
    {
        [Test]
        public void _0_VisitLight()
        {
            PatternCraftVisitor.IVisitor bullet = new PatternCraftVisitor.TankBullet();
            PatternCraftVisitor.ILightUnit light = new PatternCraftVisitor.Marine();

            light.Accept(bullet);

            Assert.AreEqual(100 - 21, light.Health);
        }

        [Test]
        public void _1_VisitArmored()
        {
            PatternCraftVisitor.IVisitor bullet = new PatternCraftVisitor.TankBullet();
            PatternCraftVisitor.IArmoredUnit armored = new PatternCraftVisitor.Marauder();

            armored.Accept(bullet);

            Assert.AreEqual(125 - 32, armored.Health);
        }
    }
}