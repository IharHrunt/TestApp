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
    public class OrderServiceTests
    {
        [Test]
        public void PlaceOrder_WhenCalled_StoreTheOrder()
        {
            var mock = new Mock<IStorage>();
            var service = new OrderService(mock.Object);

            var order = new Order();
            service.PlaceOrder(order);

            mock.Verify(s => s.Store(order));
        }
    }
}
