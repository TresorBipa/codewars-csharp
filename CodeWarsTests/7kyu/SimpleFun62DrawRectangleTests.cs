using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun62DrawRectangleTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun62DrawRectangle();

            var canvas = new string[][]
            {
                new string[] {"a", "a", "a", "a", "a", "a", "a", "a"},
                new string[] {"a", "a", "a", "a", "a", "a", "a", "a"},
                new string[] {"a", "a", "a", "a", "a", "a", "a", "a"},
                new string[] {"b", "b", "b", "b", "b", "b", "b", "b"},
                new string[] {"b", "b", "b", "b", "b", "b", "b", "b"}
            };
            var rectangle = new int[] {1, 1, 4, 3};
            var expected = new string[][]
            {
                new string[] {"a", "a", "a", "a", "a", "a", "a", "a"},
                new string[] {"a", "*", "-", "-", "*", "a", "a", "a"},
                new string[] {"a", "|", "a", "a", "|", "a", "a", "a"},
                new string[] {"b", "*", "-", "-", "*", "b", "b", "b"},
                new string[] {"b", "b", "b", "b", "b", "b", "b", "b"}
            };
            Assert.AreEqual(expected, kata.DrawRectangle(canvas, rectangle));


            canvas = new string[][]
            {
                new string[] {"a", "a", "a", "a", "a", "a", "a", "a"},
                new string[] {"a", "a", "a", "a", "a", "a", "a", "a"},
                new string[] {"a", "a", "a", "a", "a", "a", "a", "a"},
                new string[] {"b", "b", "b", "b", "b", "b", "b", "b"}
            };
            rectangle = new int[] {0, 0, 1, 1};
            expected = new string[][]
            {
                new string[] {"*", "*", "a", "a", "a", "a", "a", "a"},
                new string[] {"*", "*", "a", "a", "a", "a", "a", "a"},
                new string[] {"a", "a", "a", "a", "a", "a", "a", "a"},
                new string[] {"b", "b", "b", "b", "b", "b", "b", "b"}
            };
            Assert.AreEqual(expected, kata.DrawRectangle(canvas, rectangle));


            canvas = new string[][]
            {
                new string[] {"a", "a", "a", "a", "a", "a", "a", "a"},
                new string[] {"a", "a", "a", "a", "a", "a", "a", "a"},
                new string[] {"a", "a", "a", "a", "a", "a", "a", "a"},
                new string[] {"b", "b", "b", "b", "b", "b", "b", "b"}
            };
            rectangle = new int[] {0, 2, 7, 3};
            expected = new string[][]
            {
                new string[] {"a", "a", "a", "a", "a", "a", "a", "a"},
                new string[] {"a", "a", "a", "a", "a", "a", "a", "a"},
                new string[] {"*", "-", "-", "-", "-", "-", "-", "*"},
                new string[] {"*", "-", "-", "-", "-", "-", "-", "*"}
            };
            Assert.AreEqual(expected, kata.DrawRectangle(canvas, rectangle));


            canvas = new string[][]
            {
                new string[] {"a", "a", "a"},
                new string[] {"a", "a", "a"},
                new string[] {"a", "a", "a"},
                new string[] {"b", "b", "b"}
            };
            rectangle = new int[] {0, 0, 2, 3};
            expected = new string[][]
            {
                new string[] {"*", "-", "*"},
                new string[] {"|", "a", "|"},
                new string[] {"|", "a", "|"},
                new string[] {"*", "-", "*"}
            };
            Assert.AreEqual(expected, kata.DrawRectangle(canvas, rectangle));
        }
    }
}