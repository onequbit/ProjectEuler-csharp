using System;
using System.Collections.Generic;
using System.Text;
using CodeLibrary;

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
            "*Problem 4*".ToConsole();
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

    //public static partial class ExtensionMethods
    //{
        
    //}
}

