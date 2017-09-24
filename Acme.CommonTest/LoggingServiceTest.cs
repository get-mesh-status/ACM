using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACME.common;
using ACM.BL;
using System.Collections.Generic;

namespace Acme.CommonTest
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            // Arrange
            var changedItems = new List<ILogable>();

            var customer = new Customer(1)
            {
                EmailAddress = "fbaggins@hobbiton.me",
                FirstName = "Frodo",
                LastName = "Baggins",
                AddressList = null
            };
            changedItems.Add(customer as ILogable);

            var product = new Product(2)
            {
                ProductName = "Rake",
                ProductDescription = "Garden Rake with Steel Head",
                CurrentPrice = 6M
            };
            /* 
             var logString = this.ProductId + ": " +
                          this.ProductName + " " +
                          "Detail: " + this.ProductDescription + "'" +
                          "Status: " + this.EntityState.ToString();

             */
            changedItems.Add(product as ILogable);


            // Act
            LoggingService.writeToFile(changedItems);

            // Assert
            // Nothing here to assert
        }
    }
}
