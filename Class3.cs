using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreJava
{
    class BasicCalcy
    {
        public void Sum(int x, int y)
        {
            Console.WriteLine("Sum is : {0}", x + y);
        }
        public void Sub(int x, int y)
        {
            Console.WriteLine("Sub is : {0}", x - y);
        }
        public void Mul(int x, int y)
        {
            Console.WriteLine("Mul is : {0}", x * y);
        }
    }
    class SciCaly : BasicCalcy
    {
        public void Cos(int x)
        {
            Console.WriteLine($"Cos is : {Math.Cos(x)}");
        }
        public void Sine(int x)
        {
            Console.WriteLine($"Sin is : Math.Sin(x)");
        }
    }


    class Class3
    {
        static void Main(string[] args)
        {
            SciCaly s = new SciCaly();
            s.Cos(0);
            s.Sine(120);
            s.Mul(10, 20);
        }
    }
}
