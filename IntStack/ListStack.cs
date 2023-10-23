using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntStack
{
    internal class ListStack
    {
        private Node first;
        private Node last;

        public Node First
        {
            get { return first; }
            set { first = value; }
        }
        public Node Last
        {
            get { return last; }
            set { last = value; }
        }

        public ListStack() //Tương tự public ArrayStack(int max = 0) 
        {
            first = null;
        }

        public bool IsEmpty => first == null;

        public bool Push(int x)
        {
            Node newNode = new Node(x);
            if (IsEmpty) first = last = newNode;
            else
            {
                newNode.Next = first;
                first = newNode;
            }
            return true;
        }
        public bool Pop(out int data)
        {
            if (IsEmpty)
            {
                Console.WriteLine("Danh sach rong");
                data = -1;
                return false;
            }
            else
            {
                data = first.Data;
                Node p = first;
                first = first.Next;
                if (first == null) //Danh sach co 1 node -> Cho first = last = null
                {
                    last = null;
                }
                p = null; //Xoa p
                return true;
            }
        }
        public bool Peek(out int data)
        {
            if (IsEmpty)
            {
                Console.WriteLine("Danh sach rong");
                data = -1;
                return false;
            }
            else
            {
                data = first.Data;
                return true;
            }
        }
    }
}
