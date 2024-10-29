using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack___Queue
{
    internal class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }

        public Node() { 
            Data = default(T);
            Next = null;
        }

        public Node(T Value)
        {
            Data = Value;
            Next = null;
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
