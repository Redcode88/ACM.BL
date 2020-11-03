using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        public Customer()
        {
        }
        public Customer(int customerId)
        {
            CustomerId = customerId;
        }
        public int CustomerId { get; private set; }
        public string EmailAddres { get; set; }
        public string FirstName { get; set; }
        private string _Lastname;
        public string FullName
        {

            get
            {
                string fullName = Lastname;
                if (!string.IsNullOrEmpty(FirstName))
                {
                    if(!string.IsNullOrWhiteSpace(fullName))

                    {
                        fullName += ", ";
                    }

                    fullName += FirstName;
                }
               return fullName; 
            }
        }
        public string Lastname
        {
            get
            {
                return _Lastname;
            }
            set
            {
                _Lastname = value;
            }
        }
 
      
        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(Lastname)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddres)) isValid = false;
            return isValid ;
        }
        public static int InstanseCount { get; set; }
       
    }

    
}
