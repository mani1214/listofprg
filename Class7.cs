using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreJava
{
    public interface Draw
    {
        void draw();
    }

    class Cricle : Draw
    {
      public void draw()
        {
            Console.WriteLine("drawing circle");
        }
    }
    class Rectangle : Draw
    {
        public void draw()
        {
            Console.WriteLine("drawing rectangle...");
        }
    }
        class Class7
    {
        static void Main(string[] args)
        {
            Draw d1;
            d1=new Rectangle();
            d1.draw();
            d1 = new Cricle();
            d1.draw();
        }
    }
}
