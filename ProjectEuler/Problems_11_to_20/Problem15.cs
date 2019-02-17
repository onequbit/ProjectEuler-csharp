using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using CodeLibrary;

namespace ProjectEuler
{
    public class Problem15 : IPEProblem
    {
        public Problem15()
        {

        }

        public string Answer => _getOutput();
        
        public void ShowAnswer(object problemSize)
        {
            "*Problem 15*".ToConsole();
            Answer.ToConsole();
        }

        private string _getOutput()
        {            
            return $"{PascalsTriangle(40, 20)}";
        }

        public static BigInteger PascalsTriangle(int row, int term)
        {
            BigInteger n = row;
            BigInteger k = term;
            BigInteger nFact = n.Factorial();
            BigInteger kFact = k.Factorial();
            BigInteger n_Minus_k_Fact = (n-k).Factorial();
            return nFact / (kFact * n_Minus_k_Fact);
        }
    }

    public static partial class ExtensionMethods
    {

        public static BigInteger Factorial(this BigInteger number)
        {
            BigInteger product = 1;
            for (int i = 1; i <= number; i++)
            {
                product = product * (BigInteger)i;
            }
            return product;
        }

    }

}
