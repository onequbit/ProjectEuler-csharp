using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using ProjectEuler;
using CodeLibrary;


namespace PE_UnitTests.Eleven_to_20
{
    [TestClass]
    public class Problem16_Tests
    {        
        public Problem16_Tests()
        {
            Problem16.BuildCache(1000);
        }

        [TestMethod]
        public void GetPower_Test()
        {
            new Problem16().GetTwoPower(1000).ToString().ToConsole();
        }

        [TestMethod]
        public void StringAndDigit_Test()
        {
            var str = new Problem16().TwoPowerString(1000);
            str.ToDigitList().ToConsole();
        }

        [TestMethod]
        public void ExampleAnswer_Test()
        {
            var problemsize = 15;
            var power = new Problem16().TwoPowerString(problemsize);
            var digits = power.ToDigitList();
            var digitslist = digits.ToStringList().ToArray().Join(",");
            var sum = digits.Sum();
            $"2^{problemsize} = {power} ... {digitslist} --> {sum}".ToConsole();
        }

        [TestMethod]
        public void TwoPowers_Test()
        {
            int limit = 256;
            
            for (int i = 0; i < limit; i++)
            {
                TwoPower.Of[i].ToString().ToConsole();
            }            
        }
    }
}
