using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class OrderItems
    {
        //Base Const 
        public OrderItems()
        {

        }

        public OrderItems(int orderitemid)
        {
            OrderItemId = orderitemid;
        }

        public int OrderItemId { get; private set; }
        public int ProudctId { get; set; }
        public Decimal? PruchasePrice { get; set; }
        public int Quintity { get; set; }

        // Method place 

        public OrderItems Retrive(int orderitemid)
        {
            return new OrderItems();
        }

        public List<OrderItems> Retrive()
        {
            return new List<OrderItems>();
        }

        public bool Save()
        {
            return true;
        }


        public bool ValidOrderItems()
        {
            var isValid = true;

            if (Quintity <= 0) isValid = false;
            if (OrderItemId <= 0) isValid = false;
            if (PruchasePrice == null) isValid = false;
 
            return isValid;
        }
    }
}
