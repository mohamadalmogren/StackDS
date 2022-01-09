using System;
using System.Collections;

namespace StackDS
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();

            stack.Push(10); // insert elements in the stack
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);
            Console.WriteLine("Stack elements...");

            Console.WriteLine("the count of elements: " + stack.Count);
            Console.WriteLine("the top element in the stack is: " + stack.Peek());

            stack.Pop(); // remove the last element inserted in the stack 

            Console.WriteLine("the count of elements (updated) : " + stack.Count);
            Console.WriteLine("the top element in the stack is (updated) : " + stack.Peek());


            foreach (var item in stack)
                Console.WriteLine(item);

            stack.Clear(); // this remove all elements in the stack

            if (stack.Count == 0)
                Console.WriteLine("stack is empty plese insert some elements.");

        }
    }
}
