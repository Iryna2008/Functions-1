using System;

namespace Functions
{
    class Program
    {
        static void Calc()
        {
            Console.WriteLine("Enter first number:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter operator(+ - * /):");

            string sign = Console.ReadLine();
            string d = "Resalt:";
            if (sign == "+")
            {
                Console.WriteLine(d + (a + b));
            }
            else if (sign == "-")
            {
                Console.WriteLine(d + (a - b));
            }
            else if (sign == "*")
            {
                Console.WriteLine(d + (a * b));
            }
            else if (sign == "/")
            {
                Console.WriteLine(d + (a / b));
            }

        }
        static void Calculator(int a, int b, string _operator)      
        {
            if (_operator == "+")
            {
                Console.WriteLine(a + b);
            }
            else if (_operator == "-")
            {
                Console.WriteLine(a - b);
            }
            else if (_operator == "*")
            {
                Console.WriteLine(a * b);
            }
            else if (_operator == "/")
            {
                Console.WriteLine(a / b);
            }

        }

        static void Sum(int a, int b)
        {
            string d = "Resalt:";
            
            Console.WriteLine(d + (a + b));
        }

        static void Triangle(int c)
        {
            Console.WriteLine("Enter rows count");

            for (int f = 0; f < c; f++)
            {

                for (int y = 0; y <= f; y++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void Rhombus()
        {
            
        }

        static void Main(string[] args)
        {

            Calc();
            Console.WriteLine();

            Calculator(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), Console.ReadLine());
            Console.WriteLine();
            
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Sum(a, b);
            Console.WriteLine();

            int c = int.Parse(Console.ReadLine());
            Triangle(c);
            Console.WriteLine();

        }
    }
}
