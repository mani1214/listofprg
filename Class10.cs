using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleCoreJava
{
    class Class10
    {
        static void Main(string[] args)
        {
            List<object> li = new List<object>();
            li.Add(12);
            li.Add(11);
            li.Add("nani");
            li.Add("mani");
            li.Add(14);
            foreach(object vi in li)
            {
                Console.WriteLine(vi);
            }
        }
    }
}
