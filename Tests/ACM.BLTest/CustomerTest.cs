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
            string expected = "Harry";

            string actual = customer.FullName;

            Assert.AreEqual(expected, actual);
        }
    }
}
