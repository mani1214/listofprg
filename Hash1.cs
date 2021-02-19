using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreJava
{
    class Hash1
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();
            set.Add("mani");
            set.Add("madhu");
            set.Add("arun");
            set.Add("abhiram");
            set.Add("abhiram");
            set.Add("balu");
            foreach(string sb in set)
            {
                Console.WriteLine(sb);
            }
            Console.WriteLine("after deleting the element:"+set.Remove("arun"));
            foreach(string sb in set)
            {
                Console.WriteLine(sb);
            }
        }
    }
}
