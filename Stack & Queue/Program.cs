using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack___Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> Stack = new Stack<int>();

            Stack.Push(new Node<int>(0));
            Stack.Push(new Node<int>(1));
            Stack.Push(new Node<int>(2));
            Stack.Push(new Node<int>(3));
            Stack.Push(new Node<int>(4));
            Stack.Push(new Node<int>(5));

            Console.WriteLine(Stack.ToString());

            Console.ReadKey();
        }
    }
}
