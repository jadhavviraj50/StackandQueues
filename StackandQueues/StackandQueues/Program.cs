using System;
namespace LinkedListStackAndQueue
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------Welcome to Linked List Program----------");
            LinkedListStack stack = new LinkedListStack();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.Display();
        }
    }
}