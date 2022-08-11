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
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            //Assert
            //verify the result
            Assert.IsTrue(result);

        }
    }
}