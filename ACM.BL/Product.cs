using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class Product
    {

        //Class Constractor ..
        public Product()
        {

        }
        public Product(int productId)
        {
            ProductId = productId;
        }


        public Decimal? CurrentPrice { get; set; }
        public int ProductId { get; private set; }
        public string ProductDiscription { get; set; }
        public string ProductName { get; set; }


        public Product Retrive(int productId)
        {
            return new  Product();
        }

        public List<Product> Retrive()
        {
            return new List<Product>();
        }

        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;
            return isValid;
        }



    }
}
