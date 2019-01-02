using System;
using System.Collections.Generic;
using System.Text;
using CodeLibrary;

namespace ProjectEuler
{
    public class Problem10 : IPEProblem
    {
        /// <summary>
        /// Summation of primes
        /// </summary>
        /// <remarks>
        /// The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
        /// Find the sum of all the primes below two million.
        /// </remarks>
        /// 

        public Problem10()
        { }

        public Problem10(int limit)
        {
            ShowAnswer(limit);
        }

        public void ShowAnswer(object problemSize)
        {
            "*Problem 10*".ToConsole();
            _limit = (int)problemSize;
            Answer.ToConsole();
        }

        private int _limit = 0;

        public string Answer => _getOutput();

        private long[] _primes => _getPrimes(_limit);

        private long[] _getPrimes(int limit)
        {
            return GetPrimesUpTo(limit).ToArray();
        }

        public HashSet<long> GetPrimesUpTo(int limit)
        {
            HashSet<long> result = new HashSet<long> { };
            if (limit <= 1) return result;
            for (int i = 2; i < limit; i++)
            {
                if (i.IsPrime())
                {
                    result.Add(i);
                    // Console.Write($"{i},");
                }
            }            
            return result;
        }

        private string _getOutput()
        {
            long sum = _primes.Sum();
            return $"sum of primes under {_limit}: {sum}";
        }

        
    }
}
