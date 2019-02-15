using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeLibrary;
using ProjectEuler;
using System;
using System.Linq;
using System.Collections.Generic;

namespace PE_UnitTests.Eleven_to_20
{
    [TestClass]
    public class Problem14Tests
    {
        
        [TestMethod]
        public void Collatz_Test()
        {
            // Arrange            
            for (long n = 1; n < 10; n++)
            {
                List<long> seq = new Problem14().GetCollatzSequence(n);
                int count = seq.Count();
                string sequence = seq.ToArray().Join(",");
                $"{n}:[{count}] => {sequence}".ToConsole();
            }
            // Act
            // Assert
        }

        [TestMethod]
        public void Solution_Test()
        {
            List<long> seq = null;
            // Arrange            
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
            $"{found}:[{finalCount}] => {sequence}".ToConsole();
            // Act
            // Assert
        }


    }
}
