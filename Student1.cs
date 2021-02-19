using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreJava
{
    public class Student1
    {
        int Studentid;
            String Studentname;
            int contactinfo;
            public void showStudentinfo(int Studentid, string Studentname, int contactinfo)
            {
                this.Studentid = Studentid;
                this.Studentname = Studentname;
                this.contactinfo = contactinfo;
            }
            public void displayStudentInfo()
            {
                Console.WriteLine(Studentid);
                Console.WriteLine(Studentname);
                Console.WriteLine(contactinfo);
            }
        }
    }
