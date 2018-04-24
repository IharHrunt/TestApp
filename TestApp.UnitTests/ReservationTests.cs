using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using TestApp.Fundamentals;

namespace TestApp.UnitTests
{
    [TestFixture]
    public class ReservationTests
    {
        [Test]
        // Function_Scenario_ExpectedBehavior
        public void CanBeCanceledBy_UserISAdmin_ReturnsTrue()
        {
            //Arrange
            var reservation = new Reservation();

            //Act
            var result = reservation.CanBeCancelledBy(new User() { IsAdmin = true });

            //Assert
            //Assert.IsTrue(result);
            Assert.That(result, Is.True);
        }

        [Test]
        public void CanBeCanceledBy_MadeByUser_ReturnsTrue()
        {
            var user = new User();
            var reservation = new Reservation() { MadeBy = user };
            
            var result = reservation.CanBeCancelledBy(user);
                    
            Assert.That(result, Is.True);
        }

        [Test]
        public void CanBeCanceledBy_AnotherUser_ReturnsFalse()
        {            
            var reservation = new Reservation() { MadeBy = new User() };

            var result = reservation.CanBeCancelledBy(new User());
                        
            Assert.That(result, Is.False);
        }
    }
}
