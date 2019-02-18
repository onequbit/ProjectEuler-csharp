using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodeLibrary;

namespace ProjectEuler
{
    public static partial class PE_ExtensionMethods
    {
        
        public static char FirstChar(this string str) 
        {
            return str[0];
        }

        public static char LastChar(this string str)
        {
            return str[str.Length - 1];
        }

        public static bool IsPalindrome(this string str)
        {
            if (str.Length < 2)
            {
                return false;
            }
            if (str.FirstChar() != str.LastChar())
            {
                return false;
            }
            string checkStr = str.TrimEnds();
            while (checkStr.Length > 1)
            {
                if (checkStr.FirstChar() != checkStr.LastChar())
                {
                    return false;
                }
                checkStr = checkStr.TrimEnds();
            }
            return true;
        }

        public static string TrimEnds(this string str)
        {
            if (str.Length < 2) return "";
            return str.Substring(1, str.Length - 2);
        }

        public static List<int> ToDigitList(this string numberString)
        {
            List<int> digits = new List<int> { };
            foreach (char c in numberString.Reverse())
            {
                int digit = 0;
                int.TryParse($"{c}", out digit);
                digits.Add(digit);
            }
            return digits;
        }

        public static int GetDigit(this string numberString, int digit)
        {
            if (numberString.Length < digit) return 0;
            return int.Parse(numberString.Substring(numberString.Length - digit - 1, 1));
        }
    }
}
