using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.common
{
    // cannot instantiate static clas using new 
    public static class StringHandler
    {
        // static method becomes extension method of string class
        // using the this keyword
        public static string InsertSpaces( this string source)
        {
            string result = string.Empty;

            if(!string.IsNullOrWhiteSpace(source))
            {

                foreach(char letter in source)
                {
                    if(char.IsUpper(letter))
                    {
                        // trim any spaces already there
                        result = result.Trim();
                        result += " ";  
                    }
                    result += letter;
                }
                result = result.Trim();
              
            }
            return result;

        }
    }
}
