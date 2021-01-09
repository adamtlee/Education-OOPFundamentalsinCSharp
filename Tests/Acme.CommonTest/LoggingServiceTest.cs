using ACM;
using ACM.BL;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Acme.CommonTest
{
    /// <summary>
    /// Summary description for LoggingServiceTest
    /// </summary>
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            var changedItems = new List<ILoggable>();

            var customer = new Customer(1)
            {
                EmailAddress = "bob@mail.com",
                FirstName = "bob",
                LastName = "ross",
                AddressList = null
            };
            changedItems.Add(customer);

            var product = new Product(2)
            {
                ProductName = "Sour Gummies",
                ProductDescription = "Some Sour Candy",
                CurrentPrice = 5M
            };
            changedItems.Add(product);

            LoggingService.WriteToFile(changedItems);
        }
    }
}
