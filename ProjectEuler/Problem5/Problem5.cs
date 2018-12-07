using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodeLibrary;

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
    }
    
}
