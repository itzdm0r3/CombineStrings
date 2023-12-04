using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombineStrings
{
    public class stringLab
    {
     /*
      * TODO: Return the combination of two Strings.
      * You combine two Strings using the '+' operator.
      * For instance, String bigstr = str1 + str2.
     * This method should return the combination of two Strings.
     * @param a the first part of the string to be combined.
     * @param b the second part of the string to be combined.
     * @return the combination of strings a and b.
     */
        
        //Note: This method could be made static but for the sake of the example
        //it is left as non-static.
        public String Combine(String a, String b)
        {
            return a + b;
        }

        //EXTRA: Lambda version commented below, this version is fast 
        //and compresses the method above into a single line

        /* public String Combine(String a, String b) => a + b; */

    }
}
