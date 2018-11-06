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
            $"Hello World! The time is {DateTime.Now.ToShortTimeString()}".ToConsole();

            NewLine.ToConsole();
        
            string answer = (4.IsMultipleOf(2)) ? "is" : "is not";
            $"4 {answer} a multiple of 2".ToConsole();

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
