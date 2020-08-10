using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);

            if (productId == 2)
            {
                product.ProductName = "SunFlowers";
                product.ProductDescription = "Mini SunFlowers";
                product.CurrentPrice = 15.96m;
            }

            return product;
        }

        public bool Save(Product product)
        {
            return true;
        }
    }
}
