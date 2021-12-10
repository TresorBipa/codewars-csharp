using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun145TableGameTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun145TableGame();

            Assert.AreEqual(new int[] {1, 1, 1, 1},
                kata.TableGame(new int[][]
                {
                    new int[] {1, 2, 1},
                    new int[] {2, 4, 2},
                    new int[] {1, 2, 1}
                }));

            Assert.AreEqual(new int[] {3, 4, 2, 7},
                kata.TableGame(new int[][]
                {
                    new int[] {3, 7, 4},
                    new int[] {5, 16, 11},
                    new int[] {2, 9, 7}
                }));

            Assert.AreEqual(new int[] {-1},
                kata.TableGame(new int[][]
                {
                    new int[] {1, 4, 2},
                    new int[] {5, 10, 5},
                    new int[] {4, 7, 3}
                }));

            Assert.AreEqual(new int[] {-1},
                kata.TableGame(new int[][]
                {
                    new int[] {1, 4, 2},
                    new int[] {5, 10, 5},
                    new int[] {4, 7, 3}
                }));

            Assert.AreEqual(new int[] {-1},
                kata.TableGame(new int[][]
                {
                    new int[] {2, 4, 2},
                    new int[] {4, 6, 4},
                    new int[] {2, 4, 2}
                }));

            Assert.AreEqual(new int[] {2, 2, 2, 2},
                kata.TableGame(new int[][]
                {
                    new int[] {2, 4, 2},
                    new int[] {4, 8, 4},
                    new int[] {2, 4, 2}
                }));

            Assert.AreEqual(new int[] {1, 2, 4, 3},
                kata.TableGame(new int[][]
                {
                    new int[] {1, 3, 2},
                    new int[] {5, 10, 5},
                    new int[] {4, 7, 3}
                }));

            Assert.AreEqual(new int[] {-1},
                kata.TableGame(new int[][]
                {
                    new int[] {1, 2, 1},
                    new int[] {1, 2, 1},
                    new int[] {1, 2, 1}
                }));
        }
    }
}