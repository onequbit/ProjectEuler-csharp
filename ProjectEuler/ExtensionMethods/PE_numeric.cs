using System;
using System.Collections.Generic;
using System.Text;
using CodeLibrary;

namespace ProjectEuler
{
    public static partial class PE_ExtensionMethods
    {

        private static HashSet<int> _foundPrimesInt = new HashSet<int> { };
        private static HashSet<long> _foundPrimesLong = new HashSet<long> { };

        #region int

        public static long Sum(this long[] set)
        {
            long sum = 0;
            foreach(var number in set)
            {
                sum += number;
            }
            return sum;
        }

        public static int Sqrt(this int number)
        {
            return (int)Math.Sqrt(number);
        }

        public static bool IsMultipleOf(this int A, int B)
        {
            return A % B == 0;
        }

        public static HashSet<int> GetFactors(this int number)
        {
            var longFactors = ((long)number).GetFactors();
            HashSet<int> intFactors = new HashSet<int> { };
            foreach (long f in longFactors)
            {
                intFactors.Add((int)f);
                intFactors.Add((int)(number / f));
            }
            return intFactors;
        }

        public static bool IsPrime(this int number)
        {
            if (_foundPrimesInt.Contains(number)) return true;
            var factors = number.GetFactors();
            bool isPrime = factors.IsEmpty();
            if (isPrime) _foundPrimesInt.Add(number);
            return isPrime;
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

        public static List<int> RangeTo(this int start, int end)
        {
            List<int> set = new List<int> { };
            if (start - end > 0)
            {
                for (int i = start; i >= end; i--)
                {
                    set.Add(i);
                }
            }
            else
            {
                for (int i = start; i <= end; i++)
                {
                    set.Add(i);
                }
            }

            return set;
        }

        #endregion int

        #region long

        public static bool IsMultipleOf(this long A, long B)
        {
            return A % B == 0;
        }

        public static long Sqrt(this long number)
        {
            return (long)Math.Sqrt(number);
        }

        public static bool IsPrime(this long number)
        {
            if (_foundPrimesLong.Contains(number)) return true;
            var factors = number.GetFactors();
            bool isPrime = factors.IsEmpty();
            if (isPrime) _foundPrimesLong.Add(number);
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
                    factors.Add(number / i);
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

        #endregion long


    }
}
