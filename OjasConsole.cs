using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManikantaConsole
{
    public class OjasConsole
    {
        public static void Show(string str)
        {
            Console.Write("this is show");
        }
        public static void ShowLine(string str)
        {
            Console.WriteLine("this is showline");
        }
        public void Display(string str)
        {
            Console.Write("this is display");
        }
        public void DisplayLine(string str)
        {
            Console.WriteLine("this is displayline");
        }
        static void Main(string[] args)
        {
            OjasConsole.Show("ghjh");
            OjasConsole.ShowLine("jhdfj");
            OjasConsole ojas = new OjasConsole();
            ojas.Display("fghjk");
            ojas.DisplayLine("dfdgf");
            NumberSet ns = new NumberSet();
            ns.IsPerfect(6);
        }

    }

}
