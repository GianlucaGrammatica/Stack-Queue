using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack___Queue
{
    internal class Queue<T>
    {
        public int Count { get; set; }
        public Node<T> First { get; set; }
        public Node<T> Last { get; set; }

        public Queue()
        {
            Count = 0;
            First = null;
            Last = null;
        }

        public void Shift(Node<T> toAdd)
        {
            if (First == null)
            {
                First = toAdd;
                Last = toAdd;
                Count++;
                return;
            }

            toAdd.Next = Last;
            Last = toAdd;
            Count++;
            return;
        }

        public Node<T> UnShift()
        {
            Node<T> toRemove = null;

            Node<T> current = Last;
            while (current.Next.Next != null)
            {
                current = current.Next;
            }

            toRemove = current.Next;
            current.Next = null;
            First = current;

            return toRemove;
        }

        public override string ToString()
        {
            string toReturn = "";

            Node<T> current = Last;
            for (int i = 0; i < Count; i++)
            {
                

                toReturn += $"{current.ToString()}\t";

                if (current.Next == null)
                {
                    break;
                }
                current = current.Next;
            }

            return toReturn;
        }
    }
}
