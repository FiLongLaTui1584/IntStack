using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntStack
{
    internal class ArrayStack
    {
        private int[] stkArray;
        private int stkMax; //Số lượng tối đa
        private int stkTop; //phần tử trên đỉnh



        public int[] StkArray
        {
            get { return stkArray; }
            set { stkArray = value; }
        }
        public int StkMax
        {
            get => stkMax; 
            set 
            {
                if(value>0 && value <= 100)
                {
                    stkMax = value;
                }
                else
                {
                    stkMax = 0;
                }
            }
        }
        public int StkTop
        {
            get => stkTop;
            set => stkTop = value;
        }
        public ArrayStack(int max = 0) 
        {
            StkMax = max;
            stkArray = new int[stkMax];
            stkTop = -1;
        }


        //isEmpty, isFull, Push, Pop, Peek
        public bool isEmpty()
        {
            return stkTop == -1;
        }
        public bool isFull => stkTop == stkMax - 1;
        public bool push(int x)
        {
            if (isFull) return false;
            stkArray[++stkTop] = x; //gán giá trị x vào Array thứ Top+1
            return true;
        }
        public bool pop(out int data)
        {
            if (isEmpty())
            {
                data = -1;
                return false;
            }
            else
            {
                data = stkArray[stkTop--]; //gán giá trị data vào Array thứ Top-1
                return true;
            }
        }
        public bool peek(out int data)
        {
            if (isEmpty())
            {
                data = -1;
                return false;
            }
            else
            {
                data = stkArray[stkTop];
                return true;
            }
        }
    }
}
