using System;

namespace CopyOfStack
{
    class Program
    {
        static void Main()
        {
            MyStack<int> stack = new MyStack<int>(4);
            stack.Push(5);
            stack.Push(4);
            stack.Push(3);
            stack.Push(2);
            //stack.Push(1);

            var copy1 = new MyStack<int>(stack);
            //copy1.Push(3);
            Console.WriteLine(copy1.Peek());
            copy1.Pop();
            Console.WriteLine(copy1.Peek());
            copy1.Pop();
            Console.WriteLine(copy1.Peek());
            copy1.Pop();
            Console.WriteLine(copy1.Peek());
        }
    }
}
