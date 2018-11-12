﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ProjectEuler
{
    /*
    Even Fibonacci numbers
    Problem 2 
    Each new term in the Fibonacci sequence is generated by adding the 
    previous two terms. By starting with 1 and 2, the first 10 terms will be:

    1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...

    By considering the terms in the Fibonacci sequence whose values do not 
    exceed four million, find the sum of the even-valued terms.
        
    */

    public class Problem2
    {
        private int _maxValue = 0;
        public HashSet<int> FibonacciSequence => GetFibonacciSequence(_maxValue);        

        public Problem2(int maxValue)
        {            
            _maxValue = maxValue;            
        }

        public HashSet<int> GetFibonacciSequence(int maxVal)
        {            
            HashSet<int> fib = new HashSet<int> { };
            if (maxVal <= 0) return fib;
            fib.Add(1);
            if (maxVal == 1)
            {
                return fib;
            }
            fib.Add(2);
            if (maxVal == 2)
            {
                return fib;
            }
            int previous = fib.Count - 1;
            int nextPrevious = fib.Count - 2;
            int newValue = fib.ElementAt(previous) + fib.ElementAt(nextPrevious);

            while (newValue < maxVal)
            {
                fib.Add(newValue);
                previous = fib.Count - 1;
                nextPrevious = fib.Count - 2;
                newValue = fib.ElementAt(previous) + fib.ElementAt(nextPrevious);
            }
            return fib;
        }

        //public HashSet<int> GetMultiplesOf(int num)
        //{
        //    HashSet<int> set = new HashSet<int> { };
        //    for (int i = 1; i < _limit; i++)
        //    {
        //        if (i.IsMultipleOf(num))
        //            set.Add(i);
        //    }                
        //    return set;
        //}

    }

    public static partial class Extensionmethods
    {
        public static void PrintLines(this HashSet<int> set, string extra = "")
        {
            for (int i=0; i<set.Count; i++)            
            {
                $"{extra}[{i}]: {set.ElementAt(i)}".ToConsole();
            }
        }

        public static HashSet<int> SelectEvens(this HashSet<int> set)
        {
            HashSet<int> result = new HashSet<int> { };
            foreach(var item in set)
            {
                if (item % 2 == 0) result.Add(item);
            }
            return result;            
        }
    }
}
