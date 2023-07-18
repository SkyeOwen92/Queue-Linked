using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Linked
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Q q = new Q();
            q.EnQueue(1);
            q.EnQueue(2);
            q.EnQueue(3);
            q.EnQueue(4);
            q.Display();
            q.DeQueue();
            q.DeQueue();
            q.Display();

            Console.ReadKey();
        }
    }
}
