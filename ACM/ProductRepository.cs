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

            return product;

        }

        public bool Save(Product product)
        {
            return true;
        }
    } 
}