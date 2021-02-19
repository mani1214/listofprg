using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreJava
{
    class InvalidAgeException : Exception
    {
        public InvalidAgeException()
        {
            Console.WriteLine("Enter valid age");
        }
    }
}
