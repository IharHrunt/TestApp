using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.Mocking;

namespace TestApp.UnitTests.Mocking
{
    [TestFixture]
    public class ProductsTests
    {
        [Test]
        public void GetPrice_GoldCustomer_ApplyDiscount()
        {
            var product = new Product(){ ListPrice = 100 };

            var result = product.GetPrice(new Customer() { IsGold = true });

            Assert.That(result, Is.EqualTo(70));
        }

        [Test]
        public void GetPrice_GoldCustomer_ApplyDiscountMock()
        {
            var customer = new Mock<ICustomer>();
            customer.Setup(c => c.IsGold).Returns(true);

            var product = new Product() { ListPrice = 100 };
            var result = product.GetPrice(customer.Object);

            Assert.That(result, Is.EqualTo(70));
        }

    }
}
