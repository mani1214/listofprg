using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreJava
{
    public class Teacher1
    {
        int Teacherid;
        String Teachername;
        int contactinfo;
        public void showStudentinfo(int Teacherid, string Teachername, int contactinfo)
        {
            this.Teacherid = Teacherid;
            this.Teachername = Teachername;
            this.contactinfo = contactinfo;
        }
        public void displayStudentInfo()
        {
            Console.WriteLine(Teacherid);
            Console.WriteLine(Teachername);
            Console.WriteLine(contactinfo);
        }
    }
}
