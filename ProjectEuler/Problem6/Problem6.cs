using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    /// <summary>
    /// Sum square difference
    /// </summary>
    /// <remarks>
    /// The sum of the squares of the first ten natural numbers is,
    /// 1^2 + 2^2 + ... + 10^2 = 385
    /// The square of the sum of the first ten natural numbers is,
    /// (1 + 2 + ... + 10)^2 = 55^2 = 3025
    /// Hence the difference between the sum of the squares of the 
    /// first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
    /// Find the difference between the sum of the squares of the 
    /// first one hundred natural numbers and the square of the sum.
    /// </remarks>
    public class Problem6
    {
        public string Answer => _getOutput();
        private int _limit;
        private List<int> _range => 1.RangeTo(_limit);
        private int _sumOfSquares => GetSumSquare(_range);
        private int _squareOfSum => GetSquareSum(_range);
        private int _difference => _sumOfSquares - _squareOfSum;

        public Problem6()
        {
            "*Problem 6*".ToConsole();
            _limit = 0;
        }

        public Problem6(int limit)
        {
            "*Problem 6*".ToConsole();
            _limit = limit;            
        }

        private string _getOutput()
        {
            string set = $"Set: {_range.NumberString()}";
            string sumOfSquaresStr = $"Sum of squares: {_sumOfSquares}";
            string squareOfSum = $"Square of sum: {_squareOfSum}";
            string difference = $"difference: {_difference}";
            return $"{set} \n {sumOfSquaresStr} \n {squareOfSum} \n {difference}";

        }

        public int QuickRangeSum(int limit)
        {
            return (limit * (limit + 1)) / 2;
        }

        public int CalcRangeSum(int limit)
        {
            return 1.RangeTo(limit).Sum();
        }

        public int GetSquareSum(List<int> numbers)
        {
            return (int)numbers.ForEach(n => n * n).Sum();
        }

        public int GetSumSquare(List<int> numbers)
        {
            var sum = numbers.Sum();
            return sum * sum;
        }

    }

    //public static partial class ExtensionMethods
    //{
        
    //}
}
