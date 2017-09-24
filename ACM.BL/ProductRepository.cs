using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
  public  class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            Product product= new Product(productId);

            Object myobject = new Object();
            Console.WriteLine("Object instance:" + myobject.ToString());
            Console.WriteLine("Product:" + product.ToString());

           

            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Assorted size set of 4 bright yello mini sunflowers";
                product.CurrentPrice = 15.96M;
            }
            return product;
        }

        public bool Save(Product product)
        {
            var success = true;

            if(product.HasChanges && product.IsValid)
            {

                if(product.IsNew)
                {
                    // call an insert stored procedure
                }
                else
                {
                    // call an update stored procedure
                }

            }
            return success;
        }


        
    }
}
