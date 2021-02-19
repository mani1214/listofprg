using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreJava
{ 
    class Parent
    {
        public void Display()
        {
            Console.WriteLine("Hi this is Display mehtod from class Parent");
        }
        public virtual void Show()
        {
            Console.WriteLine("Hi this is show method from class parent");
        }
    }
    class Child : Parent
    {
        public override void Show()
        {
            Console.WriteLine("Hi this is show method from class Child");
        }
    }
    class Class6
    {
        static void Main(string[] args)
        {
            Parent p = new Parent();
            p.Display();
            p.Show();
            p = new Child();
            p.Show();
        }
    }
}
