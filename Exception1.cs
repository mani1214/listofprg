using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreJava
{
    class Exception1
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("enter the number1:");
                    int num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter the number2:");
                    int num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(num1/num2);
                    Console.WriteLine(num1+num2);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }
    }
}
