using CodeLibrary;

namespace ProjectEuler
{
    
    public class App
    {
        public App() { }
        
        public void GetSolution(IPEProblem problem, object problemSize)
        {
            problem.ShowAnswer(problemSize);
            "Press enter to continue".KeyPrompt();
        }

        public void Go()
        {
            //GetSolution(new Problem1(), 1000);
            //GetSolution(new Problem2(), 4000000);
            //GetSolution(new Problem3(), 600851475143);
            //GetSolution(new Problem4(), null);
            //GetSolution(new Problem5(), 20);
            //GetSolution(new Problem6(), 100);
            //GetSolution(new Problem7(), 10001);
            //GetSolution(new Problem8(), null);
            //GetSolution(new Problem9(), 1000);
            //GetSolution(new Problem10(), 2000000);
            //GetSolution(new Problem11(), null);
            //GetSolution(new Problem12(), 500);
            //GetSolution(new Problem13(), null);
            //GetSolution(new Problem14(), null);
            //GetSolution(new Problem15(), null);
            GetSolution(new Problem16(), null);
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
