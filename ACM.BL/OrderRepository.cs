using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {
        public Order Retrieve(int orderId)
        {

            // Create the instance of the order class 
            // pass in the requested Id
         Order order= new Order(orderId);

            // code that retrieves the data

         return order;
        }


        public OrderDisplay RetrieveOrderDisplay(int orderId)
        {

            // first creates the instant of the class it is going to populate 

            OrderDisplay orderDisplay = new OrderDisplay();

            // code that retrieves the defined order fields

            var addressRepository = new AddressRepository();

            // temporary hard coded data

            if(orderId==10)
            {

                orderDisplay.FirstName = "Bilbo";
                orderDisplay.LastName = "Baggins";
                orderDisplay.OrderDate = new DateTimeOffset(2014, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
                orderDisplay.ShippingAddress = addressRepository.Retrieve(1);

            }
            orderDisplay.OrderDisplayItemList = new List<OrderDisplayItem>();

            // code taht retrieves the order items

            // temporary hard coded data

            if (orderId==10)
            {

                var orderDisplayItem = new OrderDisplayItem()

                {
                    ProductName = "Sunflowers",
                    PurchasePrice=15.96M,
                    OrderQuantity=2
                };
                orderDisplay.OrderDisplayItemList.Add(orderDisplayItem);
                orderDisplayItem = new OrderDisplayItem()
                {
                    ProductName = "Rake",
                    PurchasePrice = 6M,
                    OrderQuantity = 1
                };
                orderDisplay.OrderDisplayItemList.Add(orderDisplayItem);

            }

            return orderDisplay;
        }

        public bool Save(Order order)
        {
            return true;
        } 
    }
}
