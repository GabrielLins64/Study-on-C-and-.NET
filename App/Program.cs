using System;
using System.Threading.Tasks;

namespace DotNet.Docker
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program myProgram = new Program();
            // myProgram.Print(args);

            // Counter(args);

            ReadInput();
        }

        static void ReadInput()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");
        }

        static void Counter(string[] args)
        {
            var counter = 0;
            var max = args.Length != 0 ? Convert.ToInt32(args[0]) : -1;
            
            while (max == -1 || counter < max)
            {
                Console.WriteLine($"Counter: {++counter}");
                Task.Delay(TimeSpan.FromMilliseconds(1_000));
            }
        }

        void Print(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Hello World!");
            Console.WriteLine("Args: " + String.Join(", ", args));
        }
    }
}
