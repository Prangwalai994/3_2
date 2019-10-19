using NUnit.Framework;
using HtmlFormatterUnitTest3_2;

namespace HtmlFormatterUnitTest3_2
{
    [TestFixture]
    public class HtmlFormatterTests
    {
        [Test]
        public void FormatAsBold_WhenCalled_ShouldEncloseTheStringWithStrongElement()
        {
            var formatter = new HtmlFormatter();

            var result = formatter.FormatAsBold("abc");

            //Specific
 //           Assert.That(result, Is.EqualTo("<strong>abc</strong>"));

            //Mor general
            Assert.That(result, Does.StartWith("<strong>"));
            Assert.That(result, Does.EndWith("</strong>"));
        }
    }
}
