using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.BS
{
   public class Product
    {
        public Product()
        {

         }

        public Product(int productID)
        {
            this.ProductId = productID;
        }

        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal CurrentPrice { get; set; }
        public int ProductId { get; private set; }

       

        public string FullProduct()
        {
            if (!string.IsNullOrWhiteSpace(ProductName))
            {
                if(ProductId != null)
                {
                    if (!string.IsNullOrWhiteSpace(Description))
                    {
                        return ProductName + " " + Description;
                    }

                    return ProductName + " " + ProductId; 
                }
                return ProductName;
            }

            return null;


        }


        public bool Validate()
        {
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName))
            {
                isValid = false;
            }
            if (CurrentPrice == null)
            {
                isValid = false;
            }
            return isValid;
        }
    }
}
