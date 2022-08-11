using NUnit.Framework;
using TestNinja.Fundamentals;

namespace UnitTestProject_1
{
    [TestFixture]
    public class HtmlFormatterTests
    {
        [Test]
        public void When_called_return_strong_element()

        {
            var feature = new HtmlFormatter();
            var result = feature.FormatAsBold("abc");
            //specific
            Assert.That(result,Is.EqualTo("<strong>abc</strong>"));
            
            //general
            //Assert.That(result,Does.StartWith("<strong>"));
            //Assert.That(result,Does.EndWith("</strong>"));
            //Assert.That(result,Does.Contain("abc"));
        }
        
    }
}