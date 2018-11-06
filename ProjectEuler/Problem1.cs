using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler
{
    /*
     Multiples of 3 and 5
     Problem 1 
     If we list all the natural numbers below 10 that are multiples of 3 or 5, 
     we get 3, 5, 6 and 9. The sum of these multiples is 23.

     Find the sum of all the multiples of 3 or 5 below 1000.
    */

    public class Problem1
    {
        
    }

    public static partial class ExtensionMethods
    {
        public static bool IsMultipleOf(this int A, int B)
        {
            return A % B == 0;
        }
    }
}
