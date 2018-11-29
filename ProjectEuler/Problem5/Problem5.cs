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
        private int _input;
        public string Answer => _getOutput();
        private HashSet<int> _primes;
        private HashSet<int> _factors;

        public Problem5(int input)
        {
            _input = input;
            "*Problem 5*".ToConsole();
        }

        private string _getOutput()
        {
            _primes = GetPrimes(_input);            
            _factors = GetInnerPowers(_input, _primes);            
            List<int> numbers = _primes.ToList().Concat(_factors.ToList()).ToList();
            string listStr = numbers.ToArray().Join("x");
            return $"{listStr} = {numbers.Product()}";
        }

        public HashSet<int> GetPrimes(int limit)
        {
            HashSet<int> result = new HashSet<int> { };
            for (int i=limit; i>1; i--)
            {
                if (i.IsPrime())
                    result.Add(i);
            }
            return result;
        }

        public HashSet<int> GetInnerPowers(int limit, HashSet<int> set)
        {
            HashSet<int> result = new HashSet<int> { };
            foreach(var item in set)
            {
                int itemPowers = (int)(System.Math.Log(limit) / System.Math.Log(item));
                if (itemPowers > 1) result.Add((int)Math.Pow(item, itemPowers-1));
            }
            return result;
        }

        private void oldtest()
        {
            "Problem 5 - test".ToConsole();
            "9...".ToConsole();
            9.GetFactors().ToConsole();
            "10...".ToConsole();
            10.GetFactors().ToConsole();
            "20...".ToConsole();
            int twenty = 20;
            twenty.GetFactors().ToConsole();
        }
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
                intFactors.Add((int)(number / f));
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

        public static HashSet<T> AddRange<T>(this HashSet<T> set, HashSet<T> otherset)
        {            
            foreach (var item in otherset)
            {
                set.Add(item);
            }
            return set;
        }

        public static int Product(this IEnumerable<int> set)
        {
            return set.Aggregate(1, (x, y) => x *= y );            
        }

    }
}
