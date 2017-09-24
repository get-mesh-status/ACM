using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
   public class CustomerRepository
    {
       // collaboration/composition relationship between 
       // CustomerRepository and AddressRepository
       private AddressRepository addressRepository { get; set; }

       public CustomerRepository()
       {
           addressRepository = new AddressRepository();
       }

        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);
            customer.AddressList = addressRepository.
                RetrieveByCustomerId(customerId).ToList();


            // Temporary hard coded values to return 
            // a populated customer instance 
            if (customerId == 1)
            {

                customer.EmailAddress = "fbaggins@hobbiton.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";

            }
            
            // code that retrieves the defined customer

            return customer; 
        }

        public List<Customer> Retrieve()
        {
            return new List<Customer>();

        }

        public bool Save(Customer customer)
        {
            // saves the defined customer
            return true;

        }
    }
}
