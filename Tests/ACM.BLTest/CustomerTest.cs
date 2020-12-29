using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            // Arrange
            Customer customer = new Customer
            {
                FirstName = "Harry",
                LastName = "Potter"
            };

            string expected = "Potter, Harry";
            /* customer.FirstName = "Harry";
               customer.LastName = "Potter"; 
            */
            // Act
            string actual = customer.FullName;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            // Arrange
            Customer customer = new Customer
            {
                LastName = "Potter"
            };
            string expected = "Potter";

            string actual = customer.FullName;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            // Arrange
            Customer customer = new Customer
            {
                FirstName = "Harry"
            };
            
            // Act
            string expected = "Harry";

            string actual = customer.FullName;


            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            // Arrange
            var c1 = new Customer();
            c1.FirstName = "Harry";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c1.FirstName = "Hermione";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c1.FirstName = "Ron";
            Customer.InstanceCount += 1;

            // Act

            // Assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }

        [TestMethod]
        public void ValidateValid()
        {
            // arrange
            var customer = new Customer
            {
                LastName = "Potter",
                EmailAddress = "hpotter@mail.com"
            };

            // act
            var expected = true;

            var actual = customer.Validate();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            // Arrange
            var customer = new Customer
            {
                EmailAddress = "hpotter@mail.com"
            };

            var expected = false;

            // Act
            var actual = customer.Validate();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
