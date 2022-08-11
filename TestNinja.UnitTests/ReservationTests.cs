using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace UnitTestProject_1
{
    [TestFixture]
    public class ReservationTests
    {
        [Test]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            //Arrange
            //Initializing the object
            var reservation = new Reservation();
            //Act
            //method we are testing
            var result=reservation.CanBeCancelledBy(new User { IsAdmin = true });
            
            //Assert
            //verify the result
            Assert.IsTrue(result);
            
        }
        [Test]
        public void canBeCancelledBy_SameUser_ReturnTrue()
        {
            var user = new User();
            var reservation = new Reservation{MadeBy=user};
            var result = reservation.CanBeCancelledBy(user);
            Assert.IsTrue(result);
        }

        [Test]
        public void CanBeCancelledBy_AnotherUser_ReturnsFalse()
        {
            var reservation = new Reservation();
            var result = reservation.CanBeCancelledBy(new User());
            //Assert.IsFalse(result);
            Assert.That(result ==false);

        }

        

    }
}