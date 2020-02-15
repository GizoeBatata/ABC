using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ABC.BS;

namespace ABC.Test
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveExisting()
        {
            //arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "hanskazan@gmail.com",
                FirstName = "Hans",
                LastName = "Kazan"
            };

            //act
            var real = customerRepository.Retrieve(1);

            //assert
            Assert.AreEqual(expected.CustomerID, real.CustomerID);
            Assert.AreEqual(expected.EmailAddress, real.EmailAddress);
            Assert.AreEqual(expected.FirstName, real.FirstName);
            Assert.AreEqual(expected.LastName, real.LastName);
        }
    }
}
