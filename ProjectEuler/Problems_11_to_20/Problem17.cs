using System;
using System.Collections.Generic;
using System.Text;
using CodeLibrary;
using System.Linq;

namespace ProjectEuler
{

    /// <summary>
    /// Number letter counts 
    /// If the numbers 1 to 5 are written out in words: 
    /// one, two, three, four, five, 
    /// then there are 3 + 3 + 5 + 4 + 4 = 19 letters 
    /// used in total.
    /// If all the numbers from 1 to 1000 
    /// (one thousand) inclusive were written out in words, 
    /// how many letters would be used?
    /// NOTE: Do not count spaces or hyphens.
    /// For example, 342 (three hundred and forty-two) 
    /// contains 23 letters and 115 (one hundred and fifteen) 
    /// contains 20 letters.
    /// The use of "and" when writing out numbers 
    /// is in compliance with British usage.
    /// </summary>
    /// <remarks>
    /// </remarks>
    
    public class Problem17 : IPEProblem
    {
        public Problem17()
        {

        }

        private string _getOutput()
        {
            string wordList = Problem17.BuildNumberWordList(1, 1000);
            string wordListStripped = Problem17.StripWhiteSpace(wordList);
            int letterCount = wordListStripped.Length;
            return $"{wordList} => {letterCount} characters";
        }

        public string Answer => _getOutput();

        public void ShowAnswer(object problemSize)
        {
            "*Problem 17*".ToConsole();
            Answer.ToConsole();
        }

        public static string StripWhiteSpace(string str)
        {
            return str
                    .Replace(",", "")
                    .Replace(" ", "");
        }

        public static string BuildNumberWordList(int start, int end)
        {
            StringBuilder sb = new StringBuilder();
            for (int i=start; i <= end; i++)
            {
                string number = new Number(i).ToString();
                sb.Append($"{number}, ");
            }
            return sb.ToString();
        }

        public static int CountLetters(string str)
        {
            return StripWhiteSpace(str).Length;
        }

    }
    
    public static partial class Lookup
    {
        public static Dictionary<int, string> NumberWord = new Dictionary<int, string>
        {
            { 0, "" },
            { 1, "one" },
            { 2, "two" },
            { 3, "three" },
            { 4, "four" },
            { 5, "five" },
            { 6, "six" },
            { 7, "seven" },
            { 8, "eight" },
            { 9, "nine" },
            { 10, "ten" },
            { 11, "eleven" },
            { 12, "twelve" },
            { 13, "thirteen" },
            { 14, "fourteen" },
            { 15, "fifteen" },
            { 18, "eighteen" },
            { 20, "twenty" },
            { 30, "thirty" },
            { 40, "forty" },
            { 50, "fifty" },
            { 60, "sixty" },
            { 70, "seventy" },
            { 80, "eighty" },
            { 90, "ninety" }
        };
    }

    public class Number
    {
        private int _value;
        private string _word => GetWord(_value);

        public override string ToString()
        {
            return _word;
        }

        public Number(int value = 0)
        {
            _value = value;
        }

        public string GetWord(int value)
        {
            if (value <= 15 || value == 18) return Lookup.NumberWord[value];
            if (value > 15 && value < 20)
            {
                return Lookup.NumberWord[value - 10] + "teen";
            }
            if (value >= 20 && value < 100)
            {
                int onesplace = value % 10;
                int tensplace = value - onesplace;
                string ones = Lookup.NumberWord[onesplace];
                string tens = Lookup.NumberWord[tensplace];
                return $"{tens}{ones}";
            }
            if (value >= 100 && value < 1000)
            {
                int hundredsplace = value / 100;
                int belowhundred = value % 100;
                string hundreds = Lookup.NumberWord[hundredsplace];
                string remainder = GetWord(belowhundred);
                string and = (belowhundred == 0) ? "" : "and";
                return $"{hundreds} hundred {and} {remainder}";
            }
            if (value >= 1000 && value < 100000)
            {
                int thousandsplace = value / 1000;
                int belowthousands = value % 1000;
                string thousands = GetWord(thousandsplace);
                string remainder = GetWord(belowthousands);
                return $"{thousands} thousand {remainder}";
            }

            return "";
        }
    }
}
