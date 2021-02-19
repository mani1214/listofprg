using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleCoreJava
{
    class SidCompare : IComparer
    {
        public int Compare(object x, object y)
        {
           Studentdt sd=(Studentdt)x;
            Studentdt sd1=(Studentdt)y;
            return 2;
        }
    }
}
