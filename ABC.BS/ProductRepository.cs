using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.BS
{
    public class ProductRepository
    {
        public Product Retrieve(int productID)
        {
            Product product = new Product(productID);

            if (productID == 2)
            {
                
                product.ProductName = "Shampoo";
                product.Description = "Product for washing hair";
                product.CurrentPrice = 12.45M;

            }
            return product;

        }

        public List<Product> Retrieve()
        {
            return new List<Product>();
        }

        public bool Save()
        {
            return true;
        }

    }
}
