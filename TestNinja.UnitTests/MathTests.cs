using NUnit.Framework;
using TestNinja.Fundamentals;

namespace UnitTestProject_1
{
    [TestFixture]
    public class MathTests
    {
        private Math _math;

        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }
        [Test]
        //[Ignore("i wanted to")]
        public void Add_WhenCalled_ReturnTheSun()
        {
            
            var result=_math.Add(1, 3);
            Assert.That(result==4);
        }

        [Test]
        [TestCase(1,2,2)]
        [TestCase(2,1,2)]
        [TestCase(1,1,1)]
        public void Max_WhenCalled_ReturnGreaterArgument(int a,int b,int expected)
        {
            
            var result = _math.Max(a,b);
            Assert.That(result==expected);
        }

        [Test]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbersUptoList()
        {
            var result = _math.GetOddNumbers(10);
            // Assert.That(result,Does.Contain(1));
            // Assert.That(result,Does.Contain(3));
            // Assert.That(result,Does.Contain(5));
            // Assert.That(result,Does.Contain(7));
            // Assert.That(result,Does.Contain(9));
            Assert.That(result,Is.EquivalentTo(new [] {1,3,5,7,9}));
            
        }
        
        
        
        


    }
}