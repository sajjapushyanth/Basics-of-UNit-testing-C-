using NUnit.Framework;
using TestNinja.Mocking;

namespace UnitTestProject_1.Mocking
{
    [TestFixture]
    public class ProductTests
    {
        [Test]
        public void GetPrice_ForGoldCust_Retrun30perdiscount()
        {
            var product = new Product { ListPrice = 100 };
            var result = product.GetPrice(new Customer() { IsGold = true });
            Assert.That(result,Is.EqualTo(70));
        }
        /*public void GetPrice_ForGoldCust_Retrun30perdiscount2()
        {
            var customer = new Mock<ICustomer>();
            customer.Setup(c => c.IsGold).Returns(true);
            
            var product = new Product { ListPrice = 100 };
            var result = product.GetPrice(customer.Object);
            Assert.That(result,Is.EqualTo(70));
        }*/

        
    }

    
}