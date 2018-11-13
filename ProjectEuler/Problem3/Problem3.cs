﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ProjectEuler
{
    /*
    Largest prime factor
    Problem 3 
    The prime factors of 13195 are 5, 7, 13 and 29.

    What is the largest prime factor of the number 600851475143 ?
    */

    public class Problem3
    {
        private long _number;
        public HashSet<long> PrimeFactors => _number.GetPrimeFactors();
        public bool IsPrime => _number.IsPrime();

        public Problem3(long number)
        {
            _number = number;
            "*Problem 3*".ToConsole();
            $"The largest prime factor of {_number} is: {PrimeFactors.Max()}"
                .ToConsole();            
        }
    }

    public static partial class Extensionmethods
    {
        public static bool IsPrime(this long number)
        {            
            var factors = number.GetFactors();
            bool isPrime = factors.IsEmpty();            
            return isPrime;
        }

        public static HashSet<long> GetFactors(this long number)
        {
            HashSet<long> factors = new HashSet<long> { };
            long root = number.Sqrt();

            for (long i = root; i > 1; i--)
            {
                bool isMultiple = number.IsMultipleOf(i);
                if (isMultiple)
                {
                    factors.Add(i);
                }
            }
            return factors;
        }

        public static HashSet<long> GetPrimeFactors(this long number)
        {
            HashSet<long> primeFactors = new HashSet<long> { };
            foreach (var factor in number.GetFactors())
            {
                if (factor.IsPrime())
                    primeFactors.Add(factor);
            }
            return primeFactors;
        }
    }
}
