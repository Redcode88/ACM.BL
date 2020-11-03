using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class Order
    {
        public Order()
        {
            //Base Const
        }

        public Order(int orderid)
        {
            OrderId = orderid;
        }

        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }

        //Method Place 

        public Order Retrive(int orderid)
        {
            return new Order();
        }

        public List<Order> Retrive()
        {
            return new List<Order>();
        }


        public bool Save()
        {

            return true;
        }

        public bool ValidateOrders()
        {
            var isValid = true;
            if (OrderDate == null) isValid = false;
            return isValid;
        }
    }
}
