using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Linked
{
    internal class Node
    {
        public int element;
        public Node next;
        public Node(int e, Node n)
        {
            element = e;
            next = n;
        }
    }
    class Q
    {
        Node Front;
        Node Rear;
        int size;
        public Q() 
        {
            Front = null;
            Rear = null;
            size = 0;
        }
        public int Length()
        {
            return size;
        }
        public bool IsEmpty()
        {
            return size == 0;
        }
        public void EnQueue(int e)//add last
        {
            Node newest = new Node(e, null);
            if(IsEmpty())
            {
                Front = newest;
            }
            else
            {
                Rear.next = newest;
            }
            Rear = newest;
            size++;
        }
        public int DeQueue()
        {
            if(IsEmpty())
            {
                Console.WriteLine("Q is Empty");
                return -1;
            }
            int e = Front.element;
            Front = Front.next;
            size--; 
            if(IsEmpty())
            {
                Rear = null;
            }
            return e;
        }
        public void Display()
        {
            Node p = Front; 
            while(p != null)
            {
                Console.Write(p.element + ", ");
                p= p.next;
            }
            Console.WriteLine();
        }
    }

}
