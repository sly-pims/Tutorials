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
            var success = true;

            if (product.HasChange)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
                    { }
                    else
                    { }
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
