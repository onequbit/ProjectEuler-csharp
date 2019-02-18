using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
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

        public static void ThrowIfNull(this object thing, string message = "")
        {
            if (thing == null) throw new NullReferenceException();
        }
        
        public static string ToNumberString(this List<int> digits)
        {
            StringBuilder sb = new StringBuilder();
            digits.Reverse();
            foreach (int digit in digits)
            {
                sb.Append($"{digit}");
            }
            return sb.ToString();
        }

    }
}
