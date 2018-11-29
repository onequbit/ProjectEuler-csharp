using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler
{
    
    /// <summary>
    /// Largest palindrome product
    /// </summary>
    /// <remarks>
    /// A palindromic number reads the same both ways. 
    /// The largest palindrome made from the product of two 2-digit numbers is 
    /// 9009 = 91 × 99.
    /// Find the largest palindrome made from the product of two 3-digit numbers.
    /// </remarks>
    public class Problem4
    {        
        public int Palindrome => DoSearch();
        public string Answer => _getOutput();
        public Problem4()
        {
            "*Problem 3*".ToConsole();
        }

        public int DoSearch()
        {
            int largest = 0;
            bool found = false;
            int count = 0;
            for (int i = 999; i > 100; i--)
            {
                for (int j = 999; j > 100; j--)
                {
                    int product = i * j;
                    found = product.ToString().IsPalindrome();
                    if (found)
                    {
                        count++;
                        if (product > largest)
                        {
                            largest = product;
                            break;
                        }
                    }
                }
            }
            $"found {count} palindromes".ToConsole();
            return largest;
        }

        private string _getOutput()
        {
            return $"largest palindrome product of two 3-digit numbers is {Palindrome}";
        }
    }

    public static partial class ExtensionMethods
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

