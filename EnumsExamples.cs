using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreJava
{
    class EnumsExamples
    {
        enum days { sunday=11, monday = 111, tuesday=222, wedesday, thursday, friday, saturday };
        static void Main(string[] args)
        {
            Console.WriteLine($"{days.sunday}=>{(int)days.sunday}");
            Console.WriteLine($"{days.monday}=>{(int)days.monday}");
            Console.WriteLine($"{days.tuesday}=>{(int)days.tuesday}");
            Console.WriteLine($"{days.wedesday}=>{(int)days.wedesday}");
            Console.WriteLine($"{days.thursday}=>{(int)days.thursday}");
        }
    }
}
