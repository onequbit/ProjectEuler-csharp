namespace ProjectEuler
{
    public class App
    {
        public App() { }

        public void Problem1()
        {
            var p1 = new Problem1(1000);
            p1.Answer.ToConsole();            
        }

        public void Problem2()
        {
            var p2 = new Problem2(4000000);
            p2.Answer.ToConsole();            
        }

        public void Problem3()
        {
            var p3 = new Problem3(600851475143);
            p3.Answer.ToConsole();
        }

        public void Problem4()
        {
            var p4 = new Problem4();
            p4.Answer.ToConsole();            
        }

        public void Problem5()
        {
            var p5 = new Problem5(20);
            p5.Answer.ToConsole();
            //System.Environment.NewLine.ToConsole();
            //p5 = new Problem5(30);
            //p5.Answer.ToConsole();
        }

        public void Go()
        {

            Problem1();
            Problem2();
            Problem3();
            Problem4();
            Problem5();            
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
