using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreJava
{
    public class Doctor
    {
        string DoctorName;
        int ConsultancyFee;
        string Specialization;
        public void ShowDoctorInfo(string dname, int fee, string spl)
        {
            DoctorName = dname;
            ConsultancyFee = fee;
            Specialization = spl;
        }
         public void DisplayDoctorInfo()
            {
                Console.WriteLine(DoctorName);
                Console.WriteLine(ConsultancyFee);
                Console.WriteLine(Specialization);
            }
        }
    }
