using System;

namespace SimpleMathCli
{
    public class Program
    {
        static void Main(string[] args)
        {
            if (args.Length <= 2)
            {
                Console.WriteLine($"Please provide the name of the method you would like to run, along with two values that are two doubles or two ints. The options are add, subtract, multiply, or divide.");
            }

            string methodName = args[0].ToLower();
            string valueOne = args[1];
            string valueTwo = args[2];

            if (int.TryParse(valueOne, out int intOne) && int.TryParse(valueTwo, out int intTwo))
            {
                switch (methodName)
                {
                    case "add":
                        Add(intOne, intTwo);
                        break;
                    case "subtract":
                        Subtract(intOne, intTwo);
                        break;
                    case "multiply":
                        Multiply(intOne, intTwo);
                        break;
                    case "divide":
                        Divide(intOne, intTwo);
                        break;
                    default:
                        break;
                }
            }
            else if (double.TryParse(valueOne, out double doubleOne) && double.TryParse(valueTwo, out double doubleTwo))
            {
                switch (methodName)
                {
                    case "add":
                        Add(doubleOne, doubleTwo);
                        break;
                    case "subtract":
                        Subtract(doubleOne, doubleTwo);
                        break;
                    case "multiply":
                        Multiply(doubleOne, doubleTwo);
                        break;
                    case "divide":
                        Divide(doubleOne, doubleTwo);
                        break;
                    default:
                        break;
                }
            }
        }

        static void Add(int a, int b)
        {
           Console.WriteLine($"{a + b}") ;
        }
        static void Add(double a, double b)
        {
           Console.WriteLine($"{a + b}") ;
        }
        static void Subtract(int a, int b)
        {
           Console.WriteLine($"{a - b}") ;
        }
        static void Subtract(double a, double b)
        {
           Console.WriteLine($"{a - b}") ;
        }
        static void Multiply(int a, int b)
        {
           Console.WriteLine($"{a * b}") ;
        }
        static void Multiply(double a, double b)
        {
           Console.WriteLine($"{a * b}") ;
        }
        static void Divide(int a, int b)
        {
           Console.WriteLine($"{a / b}") ;
        }
        static void Divide(double a, double b)
        {
           Console.WriteLine($"{a / b}") ;
        }
    }
}
