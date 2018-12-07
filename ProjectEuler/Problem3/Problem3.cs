using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using CodeLibrary;

namespace ProjectEuler
{
    
    /// <summary>
    /// Largest prime factor
    /// </summary>
    /// <remarks>
    /// The prime factors of 13195 are 5, 7, 13 and 29.
    /// What is the largest prime factor of the number 600851475143 ?    
    /// </remarks>    
    public class Problem3
    {
        private long _number;
        public HashSet<long> PrimeFactors => _number.GetPrimeFactors();
        public bool IsPrime => _number.IsPrime();
        public string Answer => _getOutput();

        public Problem3(long number)
        {
            _number = number;
            "*Problem 3*".ToConsole();            
        }

        private string _getOutput()
        {
            return $"The largest prime factor of {_number} is: {PrimeFactors.Max()}";
        }
    }
    
}
