using System;
using static System.Environment;

namespace ProjectEuler
{
    public class App
    {
        public App() { }

        public void Problem1()
        {
            var p1 = new Problem1(1000);
            $"there are {p1.Count} multiples, with sum {p1.Sum}".ToConsole();
            "Press any key to continue".KeyPrompt();
        }

        public void Problem2()
        {
            var p2 = new Problem2(4000000);
            var fib = p2.FibonacciSequence.SelectEvens();
            $"the sum of {fib.Count} items is {fib.Sum()}".ToConsole();
            "Press any key to continue".KeyPrompt();
        }

        public void Go()
        {
            // Problem1();
            Problem2();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            new App().Go();
        }
    }
}
