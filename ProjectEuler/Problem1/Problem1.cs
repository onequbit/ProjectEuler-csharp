using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using CodeLibrary;

namespace ProjectEuler
{
    /// <summary>
    /// Multiples of 3 and 5
    /// </summary>
    /// <remarks>
    /// If we list all the natural numbers below 10 that are multiples of 3 or 5, 
    /// we get 3, 5, 6 and 9. The sum of these multiples is 23.
    /// Find the sum of all the multiples of 3 or 5 below 1000.
    /// </remarks>
    
    public class Problem1
    {
        private int _limit = 0;
        private HashSet<int> _multiplesOf3;
        private HashSet<int> _multiplesOf5;
        public HashSet<int> Multiples => 
            _multiplesOf3.CopyWith(_multiplesOf5);
        public int Count => Multiples.Count;
        public int Sum => Multiples.Sum();
        public string Answer => _getOutput();

        public Problem1(int limit)
        {
            "*Problem 1*".ToConsole();
            _limit = limit;
            _multiplesOf3 = GetMultiplesOf(3);
            _multiplesOf5 = GetMultiplesOf(5);
        }

        public HashSet<int> GetMultiplesOf(int num)
        {
            HashSet<int> set = new HashSet<int> { };
            for (int i = 1; i < _limit; i++)
            {
                if (i.IsMultipleOf(num))
                    set.Add(i);
            }                
            return set;
        }

        private string _getOutput()
        {
            return $"there are {Count} multiples, with sum {Sum}";
        }

    }

    //public static partial class ExtensionMethods
    //{
        
    //}
}
