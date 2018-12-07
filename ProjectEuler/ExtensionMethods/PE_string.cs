using System;
using System.Collections.Generic;
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
        
    }
}
