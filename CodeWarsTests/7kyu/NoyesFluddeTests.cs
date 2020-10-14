using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    public class NoyesFluddeTests
    {
        [Test]
        public void BasicTests()
        {
            var expected = new char[][] {new char[] {'c', 'c'}, new char[] {'g', 'g'}};
            var actual = NoyesFludde.BoatLoader(new object[] {'g', 'c', 'h', 'c', 'g', 'm'});
            Assert.AreEqual(expected, actual, "Your result did not match up properly! This is a titanic problem!");

            expected = new char[][]
            {
                new char[] {'a', 'a'}, new char[] {'F', 'F'},
                new char[] {'G', 'G'}, new char[] {'g', 'g'}, new char[] {'r', 'r'},
                new char[] {'s', 's'}, new char[] {'X', 'X'}
            };
            actual = NoyesFludde.BoatLoader(new object[]
            {
                'a', 'd', 'G', 'V', 'X', 'F', 'g', 'h', 's', 'r', 'a', 'g', 'n', 's', 'e', 'r', 'j', 'a', 'f', 'D', 'F',
                'G', 'R', 'H', 'C', 'X', 'B', 'N', 'G', 'U', 'G', 'F', 'p', 's', 'r', 'g', 'a'
            });
            Assert.AreEqual(expected, actual, "More animals, more problems");

            expected = new char[][] {new char[] {'c', 'c'}, new char[] {'G', 'G'}, new char[] {'g', 'g'}};
            actual = NoyesFludde.BoatLoader(new object[] {'g', 'g', 'G', 'c', 'p', 'x', 'z', 'Z', 'G', 'c', 'g', 'g'});
            Assert.AreEqual(expected, actual,
                "Oh no! The animals are not in size order! The bedding arrangments will get very confused!");

            expected = new char[][] {new char[] {'c', 'c'}, new char[] {'G', 'G'}, new char[] {'g', 'g'}};
            actual = NoyesFludde.BoatLoader(new object[]
                {5, 6, 5, 'g', 'g', 'G', 'c', 'p', 'x', 'z', 'Z', 'G', 'c', 'g', 'g'});
            Assert.AreEqual(expected, actual, "Some insiduous numbers snuck onto the boat! All is lost!");
        }
    }
}