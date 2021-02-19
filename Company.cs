using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreJava
{
   public class Company
    {
        int Companyid;
        String Companyname;
        int contactinfo;
        public void showCompanyInfo(int Cid, string Cname, int phoneNumber)
        {
            Companyid = Cid;
            Companyname = Cname;
            contactinfo = phoneNumber;
        }
        public void displayCompanyInfo()
        {
            Console.WriteLine(Companyid);
            Console.WriteLine(Companyname);
            Console.WriteLine(contactinfo);
        }
    }
}
