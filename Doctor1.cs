using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreJava
{
    public class Doctor1
    {
        string DoctorName;
        int ConsultancyFee;
        string Specialization;
        public void ShowDoctorInfo(string DoctorName, int ConsultancyFee, string Specialization)
        {
            this.DoctorName = DoctorName;
            this.ConsultancyFee = ConsultancyFee;
            this.Specialization = Specialization;
        }
        public void DisplayDoctorInfo()
        {
            Console.WriteLine(DoctorName);
            Console.WriteLine(ConsultancyFee);
            Console.WriteLine(Specialization);
        }
    }
}
