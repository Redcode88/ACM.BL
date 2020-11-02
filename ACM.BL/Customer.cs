using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
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
 
        
        //Retrivng Customer Data 
        public Customer Retrieve (int CustomerId)
        {
            return new Customer();
        } 
        

        // Retriving All Customer ..

        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }




        //Saving Customer Data
        public bool Save()
        {
            return true;
        }


        // Validation Of Customer Data ....
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
