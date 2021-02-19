using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreJava
{
   public class Teacher
    {
        int Teacherid;
        String Teachername;
        int contactinfo;
        public void showTeacherinfo(int tid, string tname, int phoneNumber)
        {
            Teacherid = tid;
            Teachername = tname;
            contactinfo = phoneNumber;
        }
        public void displayTeacherInfo()
        {
            Console.WriteLine(Teacherid);
            Console.WriteLine(Teachername);
            Console.WriteLine(contactinfo);
        }
    }
}
