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

        public Problem5()
        {
            _input = 0;
        }

        public Problem5(int input)
        {
            _input = input;
            "*Problem 5*".ToConsole();
        }

        private string _getOutput()
        {
            _primes = GetPrimesUpTo(_input);
            _factors = GetInnerPrimePowersUpTo(_input);
            List<int> numbers = _primes.ToList().Concat(_factors.ToList()).ToList();
            numbers = RemoveExtraMultiples(numbers, _input);
            string listStr = numbers.ToArray().Join("x");
            return $"{listStr} = {numbers.Product()}";
        }

        public List<int> RemoveExtraMultiples(List<int> numbers, int limit)
        {            
            List<int> result = numbers.Copy();
            foreach (int n in numbers)
            {
                for (int power = 2; Math.Pow(n, power) < limit; power++)
                {
                    if (numbers.Contains((int)Math.Pow(n,power)))
                    {
                        result.Remove(n);
                        break;
                    }
                }
            }
            return result.ToList();
        }

        public HashSet<int> GetPrimesUpTo(int limit)
        {
            HashSet<int> result = new HashSet<int> { };
            if (limit <= 1) return result;
            for (int i=limit; i>1; i--)
            {
                if (i.IsPrime())
                    result.Add(i);
            }
            return result;
        }

        public HashSet<int> GetInnerPrimePowersUpTo(int limit)
        {
            HashSet<int> result = new HashSet<int> { };
            if (limit <= 1) return result;
            var set = GetPrimesUpTo(limit);
            foreach (var item in set)
            {
                int itemPowers = (int)(System.Math.Log(limit) / System.Math.Log(item));
                if (itemPowers > 1)
                {
                    result.Add((int)Math.Pow(item, itemPowers));
                }
            }
            return result;
        }

        public void InnerPrimePowers()
        {

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

        public static long Product(this IEnumerable<int> set)
        {
            return set.Aggregate((long)1, (x,y) => x = (long)(x*y) );            
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

        public static List<T> Copy<T>(this List<T> set)
        {
            T[] temp = new T[set.Count];
            set.CopyTo(temp);
            return temp.ToList<T>();
        }

    }
}
