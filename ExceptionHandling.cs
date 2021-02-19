using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreJava
{
    class ExceptionHandling
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter the number1:");
                    int num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the number2:");
                    int num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(num1/num2);
                    Console.WriteLine(num1+num2);
                }
                catch(FormatException fx)
                {
                    Console.WriteLine(fx.Message+"please enter only number");
                }
               
            }
        }
    }
}
