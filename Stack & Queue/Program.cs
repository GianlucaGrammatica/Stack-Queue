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

            //Test Stack
            /*
            Stack<int> Stack = new Stack<int>();

            Stack.Push(new Node<int>(0));
            Stack.Push(new Node<int>(1));
            Stack.Push(new Node<int>(2));
            Stack.Push(new Node<int>(3));
            Stack.Push(new Node<int>(4));
            Stack.Push(new Node<int>(5));

            Console.WriteLine(Stack.ToString());

            Console.WriteLine("\n");

            Console.WriteLine(Stack.Pop().ToString());

            Console.WriteLine("\n");

            Console.WriteLine(Stack.Pop().ToString());
            Console.WriteLine(Stack.Pop().ToString());
            Console.WriteLine(Stack.Pop().ToString());

            Console.WriteLine("\n\n");

            Console.WriteLine(Stack.ToString());

            Console.WriteLine("\n\n");

            Console.WriteLine(Stack.Pop().ToString());

            Console.WriteLine("\n\n");

            Console.WriteLine(Stack.ToString());
            */


            //Test Queue
            Queue<int> Queue = new Queue<int>();

            Queue.Shift(new Node<int>(0));
            Queue.Shift(new Node<int>(1));
            Queue.Shift(new Node<int>(2));
            Queue.Shift(new Node<int>(3));
            Queue.Shift(new Node<int>(4));
            Queue.Shift(new Node<int>(5));

            Console.WriteLine(Queue.ToString());

            Console.WriteLine("\n");

            Console.WriteLine(Queue.UnShift().ToString());

            Console.WriteLine("\n");

            Console.WriteLine(Queue.UnShift().ToString());
            Console.WriteLine(Queue.UnShift().ToString());
            Console.WriteLine(Queue.UnShift().ToString());

            Console.WriteLine("\n");

            Console.WriteLine(Queue.ToString());

            Console.WriteLine("\n\n");

            Console.WriteLine(Queue.UnShift().ToString());

            Console.WriteLine("\n\n");

            Console.WriteLine(Queue.ToString());

            Console.ReadKey();
        }
    }
}
