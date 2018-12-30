using System;
using System.Collections.Generic;
using System.Text;
using CodeLibrary;

namespace ProjectEuler
{
    public class Problem10
    {
        /// <summary>
        /// Summation of primes
        /// </summary>
        /// <remarks>
        /// The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
        /// Find the sum of all the primes below two million.
        /// </remarks>
        /// 
        public Problem10(long limit)
        {
            "*Problem 10*".ToConsole();
            _limit = limit;            
        }

        private long _limit = 0;

        public string Answer => _getOutput();

        public long[] Primes => _getPrimes(_limit);

        private long[] _getPrimes(long limit)
        {
            return GetPrimesUpTo(limit).ToArray();
        }

        public HashSet<long> GetPrimesUpTo(long limit)
        {
            HashSet<long> result = new HashSet<long> { };
            if (limit <= 1) return result;
            for (long i = 2; i < limit; i++)
            {
                if (i.IsPrime())
                {
                    result.Add(i);
                    Console.Write($"{i},");
                }
            }            
            return result;
        }

        private string _getOutput()
        {
            long sum = Primes.Sum();
            return $"sum of primes under {_limit}: {sum}";
        }

    }
}
