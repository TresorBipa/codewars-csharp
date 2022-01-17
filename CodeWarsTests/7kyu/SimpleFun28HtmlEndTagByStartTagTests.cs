using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun28HtmlEndTagByStartTagTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun28HtmlEndTagByStartTag();

            Assert.AreEqual("</button>", kata.HtmlEndTagByStartTag("<button type='button' disabled>"));

            Assert.AreEqual("</i>", kata.HtmlEndTagByStartTag("<i>"));

            Assert.AreEqual("</div>",
                kata.HtmlEndTagByStartTag(
                    "<div id='my_area' class='data' title='This is a test for title on Div tag'>"));
        }
    }
}