﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);

            if (productId == 2)
            {
                product.ProductName = "Candy";
                product.ProductDescription = "Chocolate Candy";
                product.CurrentPrice = 24.65M;
            }

            Object myObject = new Object();
            Console.WriteLine($"Object: {myObject.ToString()}");
            Console.WriteLine($"Product: {product.ToString()}");
            return product;

        }

        public bool Save(Product product)
        {
            var success = true;

            if (product.HasChanges)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
                    {
                        // Called an insert stored procedure
                    }
                    else
                    {
                        // Call an updated stored procedure
                    }
                }
                else
                {
                    success = false;
                }
            }

            return success;
        }
    } 
}
