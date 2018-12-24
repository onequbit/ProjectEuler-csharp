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
        private int _limit;
        public string Answer => _getOutput();

        private string _getOutput()
        {
            var answer = _findTriplets(_limit);
            int product = answer.Item1 * answer.Item2 * answer.Item3;
            return $"{answer} => {product}";            
        }

        public Problem9(int limit)
        {
            "*Problem 9*".ToConsole();
            _limit = limit;
        }

        /// <summary>
        /// _findTriplets
        /// </summary>
        /// <remarks>        
        /// </remarks>
        /// <returns>
        /// generates a list of tuples, where each tuple (a,b,c) 
        /// satisfies a^2 + b^2 = c^2, then returns the one tuple
        /// whose sum a + b + c = 1000
        /// </returns>
        private Tuple<int, int, int> _findTriplets(int limit)
        {             
            List<Tuple<int, int, int>> triplets = new List<Tuple<int, int, int>> { };
            for (int i = 1; i < limit; i++)
            {
                for (int j = i; j < limit; j++)
                {
                    int a = i * i;
                    int b = j * j;
                    int c = a + b;                    
                    double hypotenuse = Math.Sqrt(c);
                    int k = (int)hypotenuse;
                    if (hypotenuse % 1 == 0 && i + j + k <= limit)
                    {
                        triplets.Add(new Tuple<int,int,int>(i,j,k));
                    }                    
                }
            }
            return triplets.Where((t) =>
                t.Item1 + t.Item2 + t.Item3 == limit
            ).FirstOrDefault();
        }
        


    }

    public static partial class ExtensionMethods
    {
        public static void ToConsole(this Tuple<int,int,int> tuple)
        {
            $"({tuple.Item1}, {tuple.Item2}, {tuple.Item3}".ToConsole();
        }
    }
}
