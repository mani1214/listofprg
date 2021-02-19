using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleCoreJava
{
    class list
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(10);
            al.Add("mani");
            al.Add(12);
            al.Add(true);
            al.Add(3.5);
            foreach(object obj in al)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
