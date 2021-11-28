using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun107CompanyBotStrategyTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun107CompanyBotStrategy();

            Assert.AreEqual(4.5, kata.CompanyBotStrategy(
                new int[][]
                {
                    new int[] {3, 1},
                    new int[] {6, 1},
                    new int[] {4, 1},
                    new int[] {5, 1}
                }
            ));

            Assert.AreEqual(5, kata.CompanyBotStrategy(
                new int[][]
                {
                    new int[] {4, 1},
                    new int[] {4, -1},
                    new int[] {0, 0},
                    new int[] {6, 1}
                }
            ));

            Assert.AreEqual(0, kata.CompanyBotStrategy(
                new int[][]
                {
                    new int[] {4, -1},
                    new int[] {0, 0},
                    new int[] {5, -1}
                }
            ));

            Assert.AreEqual(4.666666666666667, kata.CompanyBotStrategy(
                new int[][]
                {
                    new int[] {3, 1},
                    new int[] {6, 1},
                    new int[] {4, -1},
                    new int[] {5, 1}
                }
            ));
        }
    }
}