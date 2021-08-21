using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class InternationalMorseCodeEncryptionTests
    {
        void Test(string morse, string english)
        {
            Assert.AreEqual(morse, InternationalMorseCodeEncryption.ToMorse(english));
        }

        [Test]
        public void Test1()
        {
            string english = "HELLO WORLD";
            string morse = ".... . .-.. .-.. ---   .-- --- .-. .-.. -..";
            Test(morse, english);
        }

        [Test]
        public void Test2()
        {
            string english = "SOS";
            string morse = "... --- ...";
            Test(morse, english);
        }

        [Test]
        public void Test3()
        {
            string english = "1836";
            string morse = ".---- ---.. ...-- -....";
            Test(morse, english);
        }

        [Test]
        public void Test4()
        {
            string english = "THE QUICK BROWN FOX";
            string morse = "- .... .   --.- ..- .. -.-. -.-   -... .-. --- .-- -.   ..-. --- -..-";
            Test(morse, english);
        }

        [Test]
        public void Test5()
        {
            string english = "JUMPED OVER THE";
            string morse = ".--- ..- -- .--. . -..   --- ...- . .-.   - .... .";
            Test(morse, english);
        }
    }
}