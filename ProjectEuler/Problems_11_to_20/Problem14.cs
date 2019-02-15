using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodeLibrary;

namespace ProjectEuler
{
    public class Problem14 : IPEProblem
    {
        /// <summary>        
        /// Longest Collatz sequence
        /// </summary>
        /// Problem 14
        /// <remarks>
        /// The following iterative sequence is defined 
        /// for the set of positive integers:
        /// n → n/2 (n is even)
        /// n → 3n + 1 (n is odd)
        /// Using the rule above and starting with 13, 
        /// we generate the following sequence:
        /// 13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
        /// It can be seen that this sequence 
        /// (starting at 13 and finishing at 1) 
        /// contains 10 terms. Although it has not been 
        /// proved yet (Collatz Problem), it is thought 
        /// that all starting numbers finish at 1.
        /// Which starting number, under one million, produces the longest chain?
        /// NOTE: Once the chain starts the terms are allowed to go above one million.
        /// </remarks>

        public Problem14()
        {

        }

        public string Answer => _getOutput();

        public void ShowAnswer(object problemSize)
        {
            "*Problem 14*".ToConsole();
            Answer.ToConsole();
        }

        private string _getOutput()
        {
            List<long> seq = null;
            int largest = 0;
            long found = 0;
            for (long n = 1; n < 1000000; n++)
            {
                seq = new Problem14().GetCollatzSequence(n);
                int count = seq.Count();
                if (count > largest)
                {
                    found = seq[0];
                    largest = count;
                }
            }
            seq = new Problem14().GetCollatzSequence(largest);
            int finalCount = seq.Count();
            string sequence = seq.ToArray().Join(",");
            return $"{found}:[{finalCount}] => {sequence}";
        }


        public List<long> GetCollatzSequence(long n)
        {
            List<long> items = new List<long> { };
            long item = n;
            while (true)
            {
                items.Add(item);
                if (item == 1) break;
                item = (item % 2 == 0) ? item / 2 : (item * 3) + 1;                
            }            
            return items;
        }

    }
}
