using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreJava
{
    partial class Bank
    {
        public void MiniStatement()
        {
            Console.WriteLine("check ministatement");
        }

    }
    class OperOver
    {
        int num1;
        int num2;
        public void SetValues(int num1,int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
        public void GetValues()
        {
            Console.WriteLine($"num1 = {num1}\tnum2 = {num2}");
        }
        public static OperOver operator +(OperOver l, OperOver m)
        {
            OperOver temp = new OperOver();
            temp.num1 = l.num1 + m.num2;
            temp.num2 = l.num1 + m.num2;
            return temp;
        }
    }
    class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("O1 operator============================");
            OperOver o1 = new OperOver();
            o1.SetValues(100, 200);
            o1.GetValues();
            Console.WriteLine("O2 operator====================");
            OperOver o2 = new OperOver();
            o1.SetValues(500, 100);
            o1.GetValues();
            Console.WriteLine("R operator====================");
            OperOver r = new OperOver();
            r = o1 + o2;
            r.GetValues();
        }
    }
}
