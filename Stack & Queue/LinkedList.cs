using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Stack___Queue
{
    internal class Stack<T>
    {
        public int Count { get; set; }
        public Node<T> Bottom { get; set; }
        public Node<T> Top { get; set; }

        public Stack() { 
            Count = 0;
            Bottom = null;
            Top = null;
        }

        public void Push(Node<T> toAdd)
        {
            if(Bottom == null)
            {
                Bottom = toAdd;
                Top = toAdd;
                Count++;
                return;
            }

            Top.Next = toAdd;            
            toAdd.Next = null;
            Top = toAdd;
            Count++;
        }

        public Node<T> Pop()
        {
            Node<T> toRemove;
            Node<T> current = Bottom;
            for(int i = 0 ; i < Count; i++)
            {
                if(current.Next == Top)
                {
                    toRemove = current.Next;
                    current.Next = null;
                    Top = current;

                    Count--;
                    return toRemove;
                }

                current = current.Next;
            }

            return null;
        }



        public override string ToString()
        {
            string toReturn = "";

            Node<T> current = Bottom;
            for (int i = 0; i < Count; i++)
            {
                if (current.Next == null)
                {
                    break;
                }

                toReturn += $"{current.Next.ToString()}\n";

                current = current.Next;
            }

            return toReturn;
        }

    }
}
