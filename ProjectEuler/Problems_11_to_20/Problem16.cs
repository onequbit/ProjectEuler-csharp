using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using CodeLibrary;
using System.Linq;

namespace ProjectEuler
{
    public class Problem16 : IPEProblem
    {
        public Problem16()
        {
            if (TwoPower.Of == null || TwoPower.Of.Length == 0)
            {
                BuildCache(1000);             
            }
        }

        public string Answer => _getOutput();

        public void ShowAnswer(object problemSize)
        {
            "*Problem 16*".ToConsole();
            Answer.ToConsole();
        }

        private string _getOutput()
        {
            return GetPowerDigitSum(1000);
        }

        public string GetPowerDigitSum(int exponent)
        {
            var problemsize = exponent;
            var power = new Problem16().TwoPowerString(problemsize);
            var digits = power.ToDigitList();
            var digitslist = digits.ToStringList().ToArray().Join(",");
            var sum = digits.Sum();
            return $"2^{problemsize} = {power} ... {digitslist} --> {sum}";
        }

        public BigInteger GetTwoPower(int exponent)
        {
            return TwoPower.Of[exponent];
        }

        public static void BuildCache(int size)
        {
            TwoPower.Of = new BigInteger[size+1];
            TwoPower.Of[0] = 1;
            for (int i = 1; i <= size; i++)
            {
                if (TwoPower.Of[i] == 0)
                {
                    TwoPower.Of[i] = TwoPower.Of[i - 1] * 2;
                }
            }
        }        

        public string TwoPowerString(int exponent)
        {
            return TwoPower.Of[exponent].ToString();
        }

        public int[] TwoPowerDigits(int exponent)
        {
            return this.TwoPowerString(exponent).ToDigitList().ToArray();
        }
    }

    public static class TwoPower
    {
        public static BigInteger[] Of = null;
    }    
    
}
