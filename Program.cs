using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSeriesProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber, number1 = 0, number2 = 1, number3;
            Console.Write("Enter the number of elements: ");
            inputNumber = int.Parse(Console.ReadLine());
            Console.Write("Fibonacci Series: ");
            Console.Write(number1 + " " + number2 + " ");
            for (int i = 2; i < inputNumber; i++)
            {
                number3 = number1 + number2;
                Console.Write(number3 + " ");
                number1 = number2;
                number2 = number3;
            }
            Console.WriteLine("\n");
        }
    }
}
