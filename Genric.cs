using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreJava
{
    class Genrics<t>
    {
        public void show(t x, t y)
        {
            Console.WriteLine(x+"\t" +y); 
        }
    }

    class Genric
    {
        static void Main(string[] args)
        {
            Genrics<int> g1 = new Genrics<int>();
            g1.show(20, 30);
        }
    }

    }
