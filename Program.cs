using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreJava
{
    class Program
    {
        static void Main(string[] args)
        {
            Doctor d1 = new Doctor();
            d1.ShowDoctorInfo("Rahul", 500, "General Physician");
            d1.DisplayDoctorInfo();
            Console.WriteLine("====================================");
            Console.WriteLine("====================================");
            Doctor1 d2 = new Doctor1();
            d2.ShowDoctorInfo("Rahul Agrawal", 1000, "General Physician");
            d2.DisplayDoctorInfo();
            Console.WriteLine("====================================");
            Console.WriteLine("====================================");
            Studentdt s1 = new Studentdt();
            //s1.showStudentinfo(121, "mani", 96535477);
           // s1.displayStudentInfo();
            Console.WriteLine("====================================");
            Console.WriteLine("====================================");
            Student1 s2 = new Student1();
            s2.showStudentinfo(101, "vamshi", 5632148);
            s2.displayStudentInfo();
            Console.WriteLine("====================================");
            Console.WriteLine("====================================");
            Teacher t1 = new Teacher();
            t1.showTeacherinfo(101, "uma", 536477);
            t1.displayTeacherInfo();
            Console.WriteLine("====================================");
            Console.WriteLine("====================================");
            Teacher1 t2 = new Teacher1();
            t1.showTeacherinfo(102, "arun", 9653877);
            t1.displayTeacherInfo();
            Console.WriteLine("====================================");
            Console.WriteLine("====================================");
            Movie m1 = new Movie();
            m1.ShowMovie("Victory",100,"hyd");
            m1.DisplayMovie();
            Console.WriteLine("====================================");
            Console.WriteLine("====================================");
            Movie m2 = new Movie();
            m2.ShowMovie("kick", 150, "delhi");
            m2.DisplayMovie();
            Console.WriteLine("====================================");
            Console.WriteLine("====================================");
            Company c1 = new Company();
            c1.showCompanyInfo(5, "Ojas", 203020);
            c1.displayCompanyInfo();
            Console.WriteLine("====================================");
            Console.WriteLine("====================================");
            Company1 c2 = new Company1();
            c2.showCompanyInfo(3, "TCS", 203028);
            c2.displayCompanyInfo();
            Console.WriteLine("====================================");
            Console.WriteLine("====================================");
        }
    }
}
