using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManikantaConsole
{
   public class NumberSet
    {
        public bool IsPerfect(int num)
        {
            return num == Factors(num);
        }

        public int Factors(int num)
        {
            int sum = 0;
            for (int i = 1; i < num; i++)
            {
                if(num%i==0)
                {
                    sum = sum + i;
                }
            }
            return sum;
        }
    }
}
