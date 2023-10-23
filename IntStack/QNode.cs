using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntStack
{
    internal class QNode
    {
        private int left, right; 
        private Node next;


        public int Left { get => left; set => left = value; }
        public int Right { get => right; set => right = value; }

        internal Node Next { get => next; set => next = value; }

        public QNode(int x = 0, int y = 0)
        {
            left = x;
            right = y;
            next = null;
        }
    }
}
