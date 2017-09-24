using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    // callable from this solution and other outside, classes are also typed
    
    public class Customer
    {

        public Customer()
            :this(0)
        {
                
        }
        public Customer(int customerId )
        {
           // this points to current instance of the class
            this.CustomerId = customerId;
            AddressList = new List<Address>();
        }

        public List<Address> AddressList { get; set; }
        //static modifier ,ensuring that InstanceCount
        // belong to the Type Customer itself
        public static int InstanceCount { get;  set; }
        private string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }

        }

        public string FirstName { get; set; }
       
        public string EmailAddress { get; set; }

        public int CustomerId { get; private set; }

        public string FullName
        {
            get
            {
                string fullName = LastName;
                if(!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            } 
        }

       
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;
           
            Object myobjk = new Object();
            Console.WriteLine("Object created:" + myobjk.ToString());
            Console.WriteLine("Customer Object is :" + this.ToString());

            
            return isValid;
        }
        
    }
}
