using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace UnitTestProject_1
{
    [TestFixture]
    public class DemeritPointsCaclTests
    {
        // public DemeritPointsCalculator calculator;
        // [SetUp]
        // public void SetUp()
        // {
        //     var calculator = new DemeritPointsCalculator();
        // }
        [Test]
        [TestCase(-1)]
        [TestCase(301)]
        public void CalculateDemeritPoints_SpeedIsOutOfRange_ThrowsArgumentOutOfRangeException(int a)
        {
            var calculator = new DemeritPointsCalculator();
            Assert.That(() => calculator.CalculateDemeritPoints(a),Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
            //calculator.CalculateDemeritPoints(-1);
        }
        

        [Test]
        [TestCase(0,0)]
        [TestCase(64,0)]
        [TestCase(65,0)]
        [TestCase(70,1)]
        [TestCase(75,2)]
        public void CalculateDemeritPoints_WhenCalledReturnDemeritPoints_ReturnsZero(int speed,int expected)
        {
            var calculator = new DemeritPointsCalculator();
            var points=calculator.CalculateDemeritPoints(speed);
            Assert.That(points==expected);


        }

        
    }
}