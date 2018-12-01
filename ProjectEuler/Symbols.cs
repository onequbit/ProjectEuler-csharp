using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler
{
    public class Symbols
    {
        public Symbols()
        {
            Console.OutputEncoding = Encoding.Unicode;
        }

        public const char SquareRootChar = '\u221A';

        public static string InSquareRoot(int number)
        {
            return $"{Symbols.SquareRootChar}({number})";
        }
    }
}
