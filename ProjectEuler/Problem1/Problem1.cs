using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ProjectEuler
{
    /*
     Multiples of 3 and 5
     Problem 1 
     If we list all the natural numbers below 10 that are multiples of 3 or 5, 
     we get 3, 5, 6 and 9. The sum of these multiples is 23.

     Find the sum of all the multiples of 3 or 5 below 1000.
    */

    public class Problem1
    {
        private int _limit = 0;
        private HashSet<int> _multiplesOf3;
        private HashSet<int> _multiplesOf5;
        public HashSet<int> Multiples => 
            _multiplesOf3.CopyWith(_multiplesOf5);
        public int Count => Multiples.Count;
        public int Sum => Multiples.Sum();

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

    }

    public static partial class ExtensionMethods
    {
        public static bool IsMultipleOf(this int A, int B)
        {
            return A % B == 0;
        }

        public static HashSet<T> CopyWith<T>(this HashSet<T> set, HashSet<T> otherSet)
        {
            HashSet<T> newSet = new HashSet<T> { };
            foreach (var item in set)
                newSet.Add(item);
            foreach (var item in otherSet)
                newSet.Add(item);
            return newSet;
        }

        public static int Sum(this HashSet<int> set)
        {
            int accumulator = 0;
            foreach(int i in set)
            {
                accumulator += i;
            }
            return accumulator;
        }
        
    }
}
