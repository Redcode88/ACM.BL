using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTEST
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()

        {
            //-- Arrang with object initializer Way
            Customer customer = new Customer
            {
                FirstName="medo",
                Lastname="mohsen"
            };
            //Actuale
            string Expected = "medo, mohsen";
            string Actual = customer.FullName;
            // Assert
            Assert.AreEqual(Expected, Actual);
        }
        
        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //-- Arrang with object initializer Way
            Customer customer = new Customer
            {
                Lastname = "mohsen"
            };
            //Actuale
            string Expected = "mohsen";
            string Actual = customer.FullName;
            // Assert
            Assert.AreEqual(Expected, Actual);
        }
        [TestMethod]
        public void StaticTest()
        {
            var c1 = new Customer();
            c1.FirstName = "Ahmed";
            Customer.InstanseCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Mohamed";
            Customer.InstanseCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Mohsen";
            Customer.InstanseCount += 1;

            Assert.AreEqual(3, Customer.InstanseCount);
        }

        [TestMethod]
        public void ValidValidate()
        {

            var Customer = new Customer()
            {
                Lastname="mohsen",
                EmailAddres="medomohsen293@gmail.com"
            };

            var Expected = true;
            var Actual = Customer.Validate();
            // Assert
            Assert.AreEqual(Expected, Actual);
        }
    }
}
