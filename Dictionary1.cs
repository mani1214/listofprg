using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreJava
{
    class Dictionary1
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dc = new Dictionary<int, string>();
            dc.Add(1, "mani");
            dc.Add(5, "madhu");
            dc.Add(4, "vamshi");
            dc.Add(6, "mouni");
            dc.Add(3, "priti");
            foreach (object ob in dc)
            {
                Console.WriteLine(ob);
            }
       }
    }
}
