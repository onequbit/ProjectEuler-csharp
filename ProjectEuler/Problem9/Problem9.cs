using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using CodeLibrary;

namespace ProjectEuler
{
    /// <summary>
    /// Special Pythagorean triplet
    /// </summary>
    /// <remarks>    
    /// A Pythagorean triplet is a set of three natural numbers, 
    /// a less than b less than c,
    /// for which,
    /// a^2 + b^2 = c^2
    /// For example, 3^2 + 4^2 = 9 + 16 = 25 = 52.
    /// There exists exactly one Pythagorean triplet for which a + b + c = 1000.
    /// Find the product abc.
    /// </remarks>

    public class Problem9
    {
        public string Answer => _getOutput();
        private string _getOutput()
        {
            return "";
        }

        private int _a = 3;
        private int _b = 4;
        private int _c = 5;
        
        private bool IsPythagoreanTriple(int a, int b, int c)
        {
            return ((a * a) + (b * b)) == (c * c);
        }

        private bool IsSolution(int a, int b, int c)
        {
            return IsPythagoreanTriple(a, b, c) && (a + b + c == 1000);
        }

        private int[] _numbers => Enumerable.Range(1, 1000).ToArray();
        private int[] _squares => _numbers.Select(x => x * x).ToArray();
        

        public Problem9()
        {
            "*Problem 9*".ToConsole();
            
        }

        private void FindSolution()
        {
            List<int> pool = _numbers.ToList();


        }

        private List<int> FilterBySum(List<int> pool)
        {
            
        }


    }

    public static partial class ExtensionMethods
    {
        
    }
}
