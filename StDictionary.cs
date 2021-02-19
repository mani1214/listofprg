using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreJava
{
    class StDictionary
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, string> sd = new SortedDictionary<int, string>();
            sd.Add(1, "mani");
            sd.Add(5, "madhu");
            sd.Add(3, "raju");
            sd.Add(2, "vani");
            sd.Add(8, "sravani");
            sd.Add(6, "sravani");
            foreach(object ob in sd)
            {
                Console.WriteLine(ob);
            }
        }
    }
}
