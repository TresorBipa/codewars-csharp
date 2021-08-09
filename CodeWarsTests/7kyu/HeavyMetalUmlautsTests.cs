using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataHeavyMetalUmlautsTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("Ännöüncïng thë Mäcböök Äïr Güïtär",
                KataHeavyMetalUmlauts.HeavyMetalUmlauts("Announcing the Macbook Air Guitar"));
            Assert.AreEqual("Fäcëböök ïntrödücës nëw hëävÿ mëtäl rëäctïön büttöns",
                KataHeavyMetalUmlauts.HeavyMetalUmlauts("Facebook introduces new heavy metal reaction buttons"));
            Assert.AreEqual("Ströng sälës öf Gööglë's VR Mëtälhëädsëts sënd tëch stöck prïcës söärïng",
                KataHeavyMetalUmlauts.HeavyMetalUmlauts(
                    "Strong sales of Google's VR Metalheadsets send tech stock prices soaring"));
            Assert.AreEqual("Vëgän Bläck Mëtäl Chëf hïts thë bïg tïmë ön Ämäzön TV",
                KataHeavyMetalUmlauts.HeavyMetalUmlauts("Vegan Black Metal Chef hits the big time on Amazon TV"));
        }
    }
}