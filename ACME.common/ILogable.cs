using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.common
{
   public  interface ILogable
    {
       // no implentation is there for interface , 
       // members  in the interface default are public
       string Log();

    }
}
