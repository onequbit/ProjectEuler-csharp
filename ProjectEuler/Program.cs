namespace ProjectEuler
{
    public class App
    {
        public App() { }

        public void Problem1()
        {
            var p1 = new Problem1(1000);
            $"there are {p1.Count} multiples, with sum {p1.Sum}".ToConsole();
            "".ToConsole();
        }

        public void Problem2()
        {
            var p2 = new Problem2(4000000);
            var fib = p2.FibonacciSequence.SelectEvens();
            $"the sum of {fib.Count} items is {fib.Sum()}".ToConsole();
            "".ToConsole();
        }

        public void Problem3()
        {
            var p3 = new Problem3(600851475143);
            "".ToConsole();
        }

        public void Go()
        {
            Problem1();
            Problem2();
            Problem3();
            "Press enter to continue".KeyPrompt();
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            
            new App().Go();
        }

    }
}
