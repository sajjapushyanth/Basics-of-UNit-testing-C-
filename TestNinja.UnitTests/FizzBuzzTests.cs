using NUnit.Framework;
using TestNinja.Fundamentals;

namespace UnitTestProject_1
{
    [TestFixture]
    
    public class FizzBuzzTests
    {
        [Test]
        [TestCase(15,"FizzBuzz")]
        [TestCase(9,"Fizz")]
        [TestCase(10,"Buzz")]
        [TestCase((1),"1")]
        public void GetOutput_if3and5_ReturnFizzBuzz(int a,string expected)
        {
            var result = FizzBuzz.GetOutput(a);
            //var result=fizzbuzz.GetOutput(a);
            
            Assert.That(result,Is.EqualTo(expected));
        }
        
        // [Test]
        // public void GetOutput_if3_ReturnFizzBuzz()
        // {
        //     var fizzbuzz = new FizzBuzz();
        //     var result=fizzbuzz.GetOutput(9);
        //     
        //     Assert.That(result,Is.EqualTo("Fizz"));
        // }
        // [Test]
        // public void GetOutput_if5_ReturnFizzBuzz()
        // {
        //     var fizzbuzz = new FizzBuzz();
        //     var result=fizzbuzz.GetOutput(10);
        //     
        //     Assert.That(result,Is.EqualTo("Buzz"));
        // }
        
    }
}