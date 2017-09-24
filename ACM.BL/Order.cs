using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
   public  class Order
    {
       public Order()
       {

       }
       public Order(int orderId)
       {
           this.OrderId = orderId;
       }

       // a nullable value type, tracks the date,time and timezone offset
       //e.g. detroit or paris order 10am time will not be placed at the same time

       public DateTimeOffset? OrderDate { get; set; }
       public int OrderId { get; private set; }

      
     
       

       public bool Validate()
       {
           var isValid = true;
           if (OrderDate == null) isValid = false;

           return isValid;
       }

    }
}
