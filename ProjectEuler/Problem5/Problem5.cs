using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    /// <summary>
    /// Smallest multiple
    /// </summary>
    /// <remarks>
    /// 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
    /// What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
    /// </remarks>
    
    public class Problem5
    {

    }

    public static partial class ExtensionMethods
    {

        public static HashSet<int> GetFactors(this int number)
        {
            var longFactors = ((long)number).GetFactors();            
            HashSet<int> intFactors = new HashSet<int> { };
            foreach(long f in longFactors)
            {
                intFactors.Add((int)f);
            }
            return intFactors;                
        }

        public static bool IsPrime(this int number)
        {
            return ((long)number).IsPrime();           
        }

        public static HashSet<int> GetPrimeFactors(this int number)
        {
            var longFactors = ((long)number).GetPrimeFactors();
            HashSet<int> intFactors = new HashSet<int> { };
            foreach (long f in longFactors)
            {
                intFactors.Add((int)f);
            }
            return intFactors;
        }

        
    }
}
