using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataIsSatorSquareTests
    {
        [Test]
        public void Test_1()
        {
            char[,] Tablet = new char[3, 3]
            {
                {'P', 'E', 'R'},
                {'E', 'V', 'E'},
                {'R', 'E', 'P'}
            };

            Assert.AreEqual(true, KataIsSatorSquare.IsSatorSquare(Tablet));
        }

        [Test]
        public void Test_2()
        {
            char[,] Tablet = new char[4, 4]
            {
                {'K', 'N', 'I', 'T'},
                {'N', 'O', 'R', 'I'}, //  warning: O and 0 look similar
                {'I', 'R', '0', 'N'}, //           but are not the same
                {'T', 'I', 'N', 'K'}
            };

            Assert.AreEqual(false, KataIsSatorSquare.IsSatorSquare(Tablet));
        }

        [Test]
        public void Test_3()
        {
            char[,] Tablet = new char[5, 5]
            {
                {'S', 'A', 'T', 'O', 'R'},
                {'A', 'R', 'E', 'P', 'O'},
                {'T', 'E', 'N', 'E', 'T'},
                {'O', 'P', 'E', 'R', 'A'},
                {'R', 'O', 'T', 'A', 'S'}
            };

            Assert.AreEqual(true, KataIsSatorSquare.IsSatorSquare(Tablet));
        }
    }
}