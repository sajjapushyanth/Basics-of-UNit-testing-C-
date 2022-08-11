using NUnit.Framework;
using TestNinja.Fundamentals;

namespace UnitTestProject_1
{
    [TestFixture]
    public class CustomerControllerTests
    {
        [Test]
        public void GetCustomer_ifIdiszero_ReturnNotFound()
        {
            var f = new CustomerController();
            var result = f.GetCustomer(0);
            //
            Assert.That(result,Is.TypeOf<NotFound>());
        }

        [Test]
        public void GetCusotmer_IfIdIsNotZero_ReturnOk()
        {
            var f = new CustomerController();
            var result = f.GetCustomer(9);
            Assert.That(result,Is.TypeOf<Ok>());
            
        }

    }
}