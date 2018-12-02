using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ProjectEuler
{
    /// <summary>
    /// Largest product in a series
    /// </summary>
    /// <remarks>
    /// The four adjacent digits in the 1000-digit number 
    /// that have the greatest product are 9 × 9 × 8 × 9 = 5832.
    ///
    /// 73167176531330624919225119674426574742355349194934
    /// 96983520312774506326239578318016984801869478851843
    /// 85861560789112949495459501737958331952853208805511
    /// 12540698747158523863050715693290963295227443043557
    /// 66896648950445244523161731856403098711121722383113
    /// 62229893423380308135336276614282806444486645238749
    /// 30358907296290491560440772390713810515859307960866
    /// 70172427121883998797908792274921901699720888093776
    /// 65727333001053367881220235421809751254540594752243
    /// 52584907711670556013604839586446706324415722155397
    /// 53697817977846174064955149290862569321978468622482
    /// 83972241375657056057490261407972968652414535100474
    /// 82166370484403199890008895243450658541227588666881
    /// 16427171479924442928230863465674813919123162824586
    /// 17866458359124566529476545682848912883142607690042
    /// 24219022671055626321111109370544217506941658960408
    /// 07198403850962455444362981230987879927244284909188
    /// 84580156166097919133875499200524063689912560717606
    /// 05886116467109405077541002256983155200055935729725
    /// 71636269561882670428252483600823257530420752963450
    /// 
    /// Find the thirteen adjacent digits in the 1000-digit 
    /// number that have the greatest product. What is the 
    /// value of this product?
    /// </remarks>

    /*
     * Since any product of a sequence of these individual 
     * digits would be zero if that sequence contains a
     * zero, the zero will be used as a string separator.
     * Thus, the 1000-digit sequence will be broken up into
     * shorter sequences, provided they are at least 13 
     * digits in length.
     */
    public class Problem8
    {
        private const string NUMBERSTRING =
            "73167176531330624919225119674426574742355349194934" +
            "96983520312774506326239578318016984801869478851843" +
            "85861560789112949495459501737958331952853208805511" +
            "12540698747158523863050715693290963295227443043557" +
            "66896648950445244523161731856403098711121722383113" +
            "62229893423380308135336276614282806444486645238749" +
            "30358907296290491560440772390713810515859307960866" +
            "70172427121883998797908792274921901699720888093776" +
            "65727333001053367881220235421809751254540594752243" +
            "52584907711670556013604839586446706324415722155397" +
            "53697817977846174064955149290862569321978468622482" +
            "83972241375657056057490261407972968652414535100474" +
            "82166370484403199890008895243450658541227588666881" +
            "16427171479924442928230863465674813919123162824586" +
            "17866458359124566529476545682848912883142607690042" +
            "24219022671055626321111109370544217506941658960408" +
            "07198403850962455444362981230987879927244284909188" +
            "84580156166097919133875499200524063689912560717606" +
            "05886116467109405077541002256983155200055935729725" +
            "71636269561882670428252483600823257530420752963450";

        private string[] _subStrings => _getSubstrings();
        private string[] _canBeScanned => _getScannableStrings();
        private string[] _scanStrings => _getScanStrings();
        private List<long> _products => _getProducts();

        public string[] subStrings => _subStrings;
        public string[] canBeScanned => _canBeScanned;
        public string[] scanStrings => _scanStrings;
        public List<long> products => _products;
        public string Answer => _getOutput();

        public Problem8()
        {
            NUMBERSTRING.ToConsole();
            "".ToConsole();
        }

        private string _getOutput()
        {
            long largest = products.Max();
            products.NumberString().ToConsole();
            return $"the largest 13-digit product: {largest}";
        }

        private string[] _getSubstrings()
        {
            return NUMBERSTRING.Split('0');
        }

        private string[] _getScannableStrings()
        {
            return _subStrings.Where(s => (s.Length >= 13)).ToArray();
        }

        private string[] _getScanStrings()
        {
            List<string> result = new List<string> { };
            foreach(string str in _canBeScanned)
            {
                result.AddRange(str.ToScanStrings(13).ToList());
            }
            return result.ToArray();
        }

        private List<long> _getProducts()
        {
            List<long> products = new List<long> { };
            foreach(string str in _scanStrings)
            {
                products.Add(str.DigitProduct());
            }
            return products;
        }
        
    }

    public static partial class ExtensionMethods
    {
        public static string[] ToScanStrings(this string collection, int size)
        {
            if (collection.Length < size) return new string[] { };
            if (collection.Length == size) return new string[] { collection };
            List<string> result = new List<string> { };
            for (int i=0; i+size <= collection.Length; i++)
            {
                result.Add(collection.Substring(i, size));
            }
            return result.ToArray();            
        }

        public static long DigitProduct(this string str)
        {
            List<int> digits = new List<int> { };
            foreach(char c in str)
            {
                digits.Add((int)Char.GetNumericValue(c));
            }
            return digits.Product();
        }
    }
}
