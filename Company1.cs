using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreJava
{
    public class Company1
    { 
            int Companyid;
            String Companyname;
            int contactinfo;
            public void showCompanyInfo(int Companyid, string Companyname, int contactinfo)
            {
               this.Companyid = Companyid;
               this.Companyname = Companyname;
               this.contactinfo = contactinfo;
            }
            public void displayCompanyInfo()
            {
                Console.WriteLine(Companyid);
                Console.WriteLine(Companyname);
                Console.WriteLine(contactinfo);
            }
        }
    }
