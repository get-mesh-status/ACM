using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderDisplay
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        // composition relationship with OrderDisplayItem Class
        // coz it needs the list of items to display 
        public List<OrderDisplayItem> OrderDisplayItemList { get; set; }
        public int OrderId { get; set; }
        // composition to the Address class
        public Address ShippingAddress { get; set; }
        public int ShippingAddressId { get; set; }
    }
}
