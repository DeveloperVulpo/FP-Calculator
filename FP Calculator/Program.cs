using System;

namespace FP_Calculator
{


    class Program
    {

        /*
            Functions
            */

        static int Add(int x, int y)
        {
            return x + y;
        }

        static int Sub(int x, int y)
        {
            return x - y;
        }

        static int Multiply(int x, int y)
        {
            return x * y;
        }

        static int Divide(int x, int y)
        {
            return x / y;
        }

        /*
        Initalizer 
        */

        static void Start()
        {
            {
                Console.Write("What is your x value: ");
                int x = Int32.Parse(Console.ReadLine());
                Console.Write("What is your y value: ");
                int y = Int32.Parse(Console.ReadLine());
                Console.Write("What is your operation? ( +, - , *, or / ): ");
                string operation = Console.ReadLine();
                switch (operation)
                {
                    case "+":
                        Console.WriteLine(Add(x, y));
                        break;
                    case "-":
                        Console.WriteLine(Sub(x, y));
                        break;
                    case "*":
                        Console.WriteLine(Multiply(x, y));
                        break;
                    case "/":
                        Console.WriteLine(Divide(x, y));
                        break;
                    default:
                        Console.WriteLine("Hey! That's not a number >:(");
                        break;
                }

            }
        }



        static void Main(string[] args)
        {
            while(true){
            Start();
            }
            
        }
    }
}
