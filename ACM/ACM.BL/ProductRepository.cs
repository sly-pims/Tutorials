using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int productId) 
        {
            Product product = new Product(productId);

            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Assorted size set of 4 sunflowers.";
                product.CurrentPrice = 15.99M;
            }
            return product;
        }

        public bool Save(Product product)
        {
            return true;
        }
    }
}
