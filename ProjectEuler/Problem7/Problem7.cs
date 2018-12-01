using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ProjectEuler
{
    /// <summary>
    /// 10001st prime
    /// </summary>
    /// <remarks>
    /// By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
    /// What is the 10 001st prime number?
    /// </remarks>
    public class Problem7
    {
        private int _limit;
        
        public string Answer => _getOutput();
        public Problem7()
        {
            "*Problem 7*".ToConsole();
            _primes = new List<int> { };
        }

        public Problem7(int limit)
        {
            "*Problem 7*".ToConsole();
            _primes = new List<int> { };
            _limit = limit;
        }

        private string _getOutput()
        {
            var primes = FindPrimes(_limit);            
            return $"prime #{_limit}: {primes[_limit - 1]}";
        }

        private List<int> _primes;

        public List<int> FindPrimes(int count)
        {
            List<int> found;
            if (count == 0)
            {
                found = new List<int> {};                
                return found;
            }
            if (count == 1)
            {
                found = new List<int> { 2 };                
                return found;
            }
            if (count == 2)
            {
                found = new List<int> { 2, 3 };                
                return found;
            }
            found = new List<int> { 2, 3 };
            int increment = 2;
            while (found.Count < count)
            {
                int candidate = found.Last() + increment;
                int root = (int)Math.Sqrt(candidate);
                bool isComposite = false;
                foreach(var item in found)
                {
                    if (item > root)
                    {
                        isComposite = false;
                        increment = 2;
                        break;
                    }
                    isComposite = candidate.IsMultipleOf(item);
                    if (isComposite)
                    {
                        increment = increment + 2;
                        break;
                    }
                }
                if (!isComposite) found.Add(candidate);
            }            
            return found;
            
        }         

        
    }

}
