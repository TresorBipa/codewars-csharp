using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class BaseConversionTests
    {
        BaseConversion k = new BaseConversion();

        [Test]
        public void BetweenNumeralSystems()
        {
            Assert.AreEqual("1111", k.Convert("15", BaseConversion.Alphabet.DECIMAL, BaseConversion.Alphabet.BINARY),
                "\"15\" dec -> bin");
            Assert.AreEqual("17", k.Convert("15", BaseConversion.Alphabet.DECIMAL, BaseConversion.Alphabet.OCTAL),
                "\"15\" dec -> oct");
            Assert.AreEqual("10", k.Convert("1010", BaseConversion.Alphabet.BINARY, BaseConversion.Alphabet.DECIMAL),
                "\"1010\" bin -> dec");
            Assert.AreEqual("a",
                k.Convert("1010", BaseConversion.Alphabet.BINARY, BaseConversion.Alphabet.HEXA_DECIMAL),
                "\"1010\" bin -> hex");
        }

        [Test]
        public void BetweenOtherBases()
        {
            Assert.AreEqual("a", k.Convert("0", BaseConversion.Alphabet.DECIMAL, BaseConversion.Alphabet.ALPHA),
                "\"0\" dec -> alpha");
            Assert.AreEqual("bb", k.Convert("27", BaseConversion.Alphabet.DECIMAL, BaseConversion.Alphabet.ALPHA_LOWER),
                "\"27\" dec -> alpha lower");
            Assert.AreEqual("320048",
                k.Convert("hello", BaseConversion.Alphabet.ALPHA_LOWER, BaseConversion.Alphabet.HEXA_DECIMAL),
                "\"hello\" alpha lower -> hex");
            Assert.AreEqual("SAME",
                k.Convert("SAME", BaseConversion.Alphabet.ALPHA_UPPER, BaseConversion.Alphabet.ALPHA_UPPER),
                "\"SAME\" alpha upper -> alpha upper");
        }

        [Test]
        public void BinaryToAny()
        {
            var input = "1001001100101100000001011010010"; // = 1234567890 dec
            Assert.AreEqual("11145401322",
                k.Convert(input, BaseConversion.Alphabet.BINARY, BaseConversion.Alphabet.OCTAL),
                "\"" + input + "\" bin -> oct");
            Assert.AreEqual("1234567890",
                k.Convert(input, BaseConversion.Alphabet.BINARY, BaseConversion.Alphabet.DECIMAL),
                "\"" + input + "\" bin -> dec");
            Assert.AreEqual("499602d2",
                k.Convert(input, BaseConversion.Alphabet.BINARY, BaseConversion.Alphabet.HEXA_DECIMAL),
                "\"" + input + "\" bin -> hex");
            Assert.AreEqual("dzxprwk",
                k.Convert(input, BaseConversion.Alphabet.BINARY, BaseConversion.Alphabet.ALPHA_LOWER),
                "\"" + input + "\" bin -> alpha lower");
            Assert.AreEqual("DZXPRWK",
                k.Convert(input, BaseConversion.Alphabet.BINARY, BaseConversion.Alphabet.ALPHA_UPPER),
                "\"" + input + "\" bin -> alpha upper");
            Assert.AreEqual("dmSkYk", k.Convert(input, BaseConversion.Alphabet.BINARY, BaseConversion.Alphabet.ALPHA),
                "\"" + input + "\" bin -> alpha");
            Assert.AreEqual("1ly7vk",
                k.Convert(input, BaseConversion.Alphabet.BINARY, BaseConversion.Alphabet.ALPHA_NUMERIC),
                "\"" + input + "\" bin -> alpha numeric");
        }

        [Test]
        public void DecimalToAny()
        {
            var input = "1337";
            Assert.AreEqual("10100111001",
                k.Convert(input, BaseConversion.Alphabet.DECIMAL, BaseConversion.Alphabet.BINARY),
                "\"" + input + "\" dec -> bin");
            Assert.AreEqual("2471", k.Convert(input, BaseConversion.Alphabet.DECIMAL, BaseConversion.Alphabet.OCTAL),
                "\"" + input + "\" dec -> oct");
            Assert.AreEqual("539",
                k.Convert(input, BaseConversion.Alphabet.DECIMAL, BaseConversion.Alphabet.HEXA_DECIMAL),
                "\"" + input + "\" dec -> hex");
            Assert.AreEqual("bzl",
                k.Convert(input, BaseConversion.Alphabet.DECIMAL, BaseConversion.Alphabet.ALPHA_LOWER),
                "\"" + input + "\" dec -> alpha lower");
            Assert.AreEqual("BZL",
                k.Convert(input, BaseConversion.Alphabet.DECIMAL, BaseConversion.Alphabet.ALPHA_UPPER),
                "\"" + input + "\" dec -> alpha upper");
            Assert.AreEqual("zL", k.Convert(input, BaseConversion.Alphabet.DECIMAL, BaseConversion.Alphabet.ALPHA),
                "\"" + input + "\" dec -> alpha");
            Assert.AreEqual("lz",
                k.Convert(input, BaseConversion.Alphabet.DECIMAL, BaseConversion.Alphabet.ALPHA_NUMERIC),
                "\"" + input + "\" dec -> alpha numeric");
        }

        [Test]
        public void AlphaToAny()
        {
            var input = "CodeWars";
            Assert.AreEqual("110100110111011111011110001100111111110000110",
                k.Convert(input, BaseConversion.Alphabet.ALPHA, BaseConversion.Alphabet.BINARY),
                "\"" + input + "\" alpha -> bin");
            Assert.AreEqual("646737361477606",
                k.Convert(input, BaseConversion.Alphabet.ALPHA, BaseConversion.Alphabet.OCTAL),
                "\"" + input + "\" alpha -> oct");
            Assert.AreEqual("29063972814726",
                k.Convert(input, BaseConversion.Alphabet.ALPHA, BaseConversion.Alphabet.DECIMAL),
                "\"" + input + "\" alpha -> dec");
            Assert.AreEqual("1a6efbc67f86",
                k.Convert(input, BaseConversion.Alphabet.ALPHA, BaseConversion.Alphabet.HEXA_DECIMAL),
                "\"" + input + "\" alpha -> hex");
            Assert.AreEqual("fjepvaubis",
                k.Convert(input, BaseConversion.Alphabet.ALPHA, BaseConversion.Alphabet.ALPHA_LOWER),
                "\"" + input + "\" alpha -> alpha lower");
            Assert.AreEqual("FJEPVAUBIS",
                k.Convert(input, BaseConversion.Alphabet.ALPHA, BaseConversion.Alphabet.ALPHA_UPPER),
                "\"" + input + "\" alpha -> alpha upper");
            Assert.AreEqual("8fGCU1me",
                k.Convert(input, BaseConversion.Alphabet.ALPHA, BaseConversion.Alphabet.ALPHA_NUMERIC),
                "\"" + input + "\" alpha -> alpha numeric");
        }

        [Test]
        public void AlphaUpperAndLower()
        {
            Assert.AreEqual("foobar",
                k.Convert("FOOBAR", BaseConversion.Alphabet.ALPHA_UPPER, BaseConversion.Alphabet.ALPHA_LOWER),
                "\"FOOBAR\" upper -> lower");
            Assert.AreEqual("CODEWARS",
                k.Convert("codewars", BaseConversion.Alphabet.ALPHA_LOWER, BaseConversion.Alphabet.ALPHA_UPPER),
                "\"FOOBAR\" lower -> upper");
        }

        [Test]
        public void ROT13CustomAlphabet()
        {
            var rot13 = "nopqrstuvwxyzabcdefghijklmNOPQRSTUVWXYZABCDEFGHIJKLM";
            Assert.AreEqual("CodeWars", k.Convert("PbqrJnef", BaseConversion.Alphabet.ALPHA, rot13),
                "\"PbqrJnef\" alpha -> rot13");
            Assert.AreEqual("puNyyRatr", k.Convert("chAllEnge", BaseConversion.Alphabet.ALPHA, rot13),
                "\"chAllEnge\" alpha -> rot13");
        }
    }
}