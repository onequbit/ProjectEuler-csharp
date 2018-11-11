using System;
using static System.Environment;

namespace ProjectEuler
{
    public class App
    {
        public App()
        {

        }


        public void Go()
        {
            var p = new Problem1(1000);
            $"there are {p.Count} multiples, with sum {p.Sum}".ToConsole();
            "Press any key to continue".KeyPrompt();
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
