using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BLTest
{
    [TestClass()]
    public class ProductRepositoryTest
    { 
        [TestMethod()]
        public void RetrieveTest()
        {
            var productRepository = new ProductRepository();
            var expected = new Product(2)
            {
                ProductName = "Candy",
                ProductDescription = "Chocolate Candy",
                CurrentPrice = 24.65M
            };

            var actual = productRepository.Retrieve(2);

            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
        }
    }
        
}
