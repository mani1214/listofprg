using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleCoreJava
{
   
   public class StudentDetails
    {
       public  int sid;
       public  string sname;
       public  int phoneNumber;
        public StudentDetails(int sid, string sname,int phoneNumber)
        {
            this.sid = sid;
            this.sname = sname;
            this.phoneNumber = phoneNumber;
        }
        public override string ToString()
        {
            return $"{sid}\t{sname}\t{phoneNumber}";
        }
    }

   public class Studentdt
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(new StudentDetails(111, "kkk", 45000));
            al.Add(new StudentDetails(141, "sss", 55020));
            al.Add(new StudentDetails(121, "bbb", 25090));
            al.Add(new StudentDetails(110, "aaa", 50560));
            Console.WriteLine("Student Details");
            foreach(StudentDetails sd in al)
            {
                Console.WriteLine(sd);
            }
            Console.WriteLine("Displaying the elements after sorting");

            // emplist.Sort(new EIDComparer());
            al.Sort(new SidCompare());
            foreach (StudentDetails std in al)
            {
                Console.WriteLine(std);
            }
        }
    }
}
