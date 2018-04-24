using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.Fundamentals;

namespace TestApp.UnitTests
{
    [TestFixture]
    class HtmlFormatterTests
    {
        [Test]
        public void FormatAsBold_WhenCalled_ShouldReturnTheBoldString()
        {
            var formatter = new HtmlFormatter();

            var result = formatter.FormatAsBold("abc");

            Assert.That(result, Does.Contain("abc"));
            Assert.That(result, Does.EndWith("</strong>").IgnoreCase);
        }
    }
}
