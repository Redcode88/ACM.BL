using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTEST
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetriveValid()

        {
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddres = "medomohsen293@gmail.com",
                FirstName = "medo",
                Lastname ="mohsen"  
            };

            var Actual = customerRepository.Retrive(1);
            Assert.AreEqual(expected.CustomerId, Actual.CustomerId);
            Assert.AreEqual(expected.FirstName, Actual.FirstName);
            Assert.AreEqual(expected.Lastname, Actual.Lastname);
            Assert.AreEqual(expected.EmailAddres, Actual.EmailAddres);
        }
    }
}
