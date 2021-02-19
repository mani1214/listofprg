using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreJava
{
    class Queue1
    {
        static void Main(string[] args)
        {
            Queue<int> q1 = new Queue<int>();
            q1.Enqueue(10);
            q1.Enqueue(12);
            q1.Enqueue(15);
            q1.Enqueue(15);
            q1.Enqueue(9);
            foreach (object ob in q1)
            {
                Console.WriteLine(ob);
            }
            Console.WriteLine("peek element is:"+q1.Peek()); 
            Console.WriteLine("DeQueue element is:" + q1.Dequeue());
            Console.WriteLine("peek element is:" + q1.Peek());
        }
    }
}
