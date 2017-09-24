using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public enum EntityStateOption
    {
        Active,
        Deleted

    }


    // abstract class, not instantiable 
    // sealed ? no other class can inherit from it 

   public abstract class EntityBase
    {
       public EntityStateOption EntityState { get; set; }
       public bool IsNew { get; private set; }
       public bool HasChanges { get; set; }

       public bool IsValid
       {
           get
           {
               return Validate();
           }
       }

       // virtual has own but allows derived class its own
       //,abstract must be overriden,no implementation 
       public abstract bool Validate();
   }



}
