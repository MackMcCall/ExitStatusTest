using System.Runtime.InteropServices;

namespace ExitStatusTest
{
    internal class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine("Type \"yay\" or else");
            string input = Console.ReadLine();

            if (input != "yay")
            {
                Console.WriteLine("why didn't you do it?");
                return 1;
            }
            Console.WriteLine("Good Job!");
            return 0;
        }
    }
}