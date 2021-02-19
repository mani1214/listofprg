using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreJava
{
    class Product
    {
        int pId;
        string pName;
        double pPrice;
        public Product()
        {
            Console.WriteLine("Hi this is constructor with out parameters");
            pId = 0;
            pName = "";
            pPrice = 0;
        }
        public Product(int pId)
        {
            this.pId = pId;
        }
        public Product(string pName)
        {
            this.pName = pName;
        }
        public Product(double pPrice)
        {
            this.pPrice = pPrice;
        }
        public Product(int pId,string pName,double pPrice)
        {
            this.pId = pId;
            this.pName = pName;
            this.pPrice = pPrice;
        }
        public void ShowValues()
        {
            Console.WriteLine($"{pId}\t{ pName}\t{ pPrice}");
        }
    }
    class Class2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====P object=======");
            Product p = new Product();
            p.ShowValues();
            Console.WriteLine("=====q object=======");
            Product q = new Product(111, "soap", 45.6);
            q.ShowValues();
            Console.WriteLine("=====r object=======");
            Product r = new Product(45);
            r.ShowValues();
            Console.WriteLine("=====t object=======");
            Product t = new Product(245, "Lux", 50);
            t.ShowValues();
        }
    }
}
