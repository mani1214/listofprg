using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManikantaConsole;

namespace ConsoleCoreJava
{
    class Assembly
    {
        static void Main(string[] args)
        {
            OjasConsole.Show("hi this is my Show");
            OjasConsole.ShowLine("hi this is my Show Line");
            OjasConsole ojas = new OjasConsole();
            ojas.Display("hi this is my Display");
            ojas.DisplayLine("hi this is my Display Line");
            NumberSet n1 = new NumberSet();
            n1.IsPerfect(6);
        }
    }
}
