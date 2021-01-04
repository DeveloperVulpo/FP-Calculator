using System;

namespace FP_Calculator
{


    class Program
    {

        /*
            Functions
            */

        static int add(int x, int y)
        {
            return x + y;
        }

        static int sub(int x, int y)
        {
            return x - y;
        }

        static int multiply(int x, int y)
        {
            return x * y;
        }

        static int divide(int x, int y)
        {
            return x / y;
        }

        /*
        Initalizer 
        */

        static void start()
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
                        Console.WriteLine(add(x, y));
                        break;
                    case "-":
                        Console.WriteLine(sub(x, y));
                        break;
                    case "*":
                        Console.WriteLine(multiply(x, y));
                        break;
                    case "/":
                        Console.WriteLine(divide(x, y));
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
            start();
            }
            
        }
    }
}
