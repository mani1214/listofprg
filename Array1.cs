using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreJava
{
    class Array1
    {
        static void Main(string[] args)
        {
            int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 } ,{ 7, 8, 9 } };
            for(int i = 0; i < 3; i++)
            {
                for(int j=0;j<3;j++)
                {
                    if(i==j || i+j==2)
                    {
                        Console.Write(arr[i,j]+"\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
