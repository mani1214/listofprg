using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreJava
{
    class Class9
    {
        static void Main(string[] args)
        {
            string str = "mani", reverse = "";
            int Length = 0;
            Length = str.Length - 1;
            while (Length >= 0)
            {
                reverse = reverse + str[Length];
                Length--;
            }
            Console.WriteLine("Reverse word is {0}", reverse);
            Console.ReadLine();
        }


    }
    }
