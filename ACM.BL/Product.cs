﻿using ACME.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
   public class Product:EntityBase,ILogable
    {
       public Product()
       {

       }
       public Product(int productId)
       {
           this.ProductId = productId;

       }
       // a nullable type , value type that allows the def of value or null

       public Decimal? CurrentPrice { get; set; }
       public int ProductId { get; private set; }
       public string ProductDescription { get; set; }


       private String _ProductName;

       public String ProductName
       {
           get {

               //return StringHandler.InsertSpaces(_ProductName);
               return _ProductName.InsertSpaces();
           }
           set { _ProductName = value; }
       }
       
      

       
       public override  bool Validate()
       {
           var isValid = true;
           if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
           if (CurrentPrice == null) isValid = false;

           return isValid;
       }

       public override string ToString()
       {
           return ProductName;
       }

       public string Log()
       {
           var logString = this.ProductId + ": " +
                          this.ProductName + " " +
                          "Detail: " + this.ProductDescription + "'" +
                          "Status: " + this.EntityState.ToString();

           return logString;

       }
       
       
   
   }
}
