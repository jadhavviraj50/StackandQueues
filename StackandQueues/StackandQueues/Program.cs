using System;
namespace LinkedListStackAndQueue
{
    class program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("-----------Welcome to Linked List Program----------");
            bool end = true;
            Console.WriteLine("\n1.StackPush\n2.StackPickPop\n3.Enqueue\n4.Dequeue\n5.End Of Program ");
            while (end)
            {
                LinkedListStack stack = new LinkedListStack();
                LinkedListQueue queue = new LinkedListQueue();
                Console.WriteLine("\nEnter Option To Execute The Program");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        stack.Push(70);
                        stack.Push(30);
                        stack.Push(56);
                        stack.Display();
                        break;
                    case 2:
                        stack.Push(70);
                        stack.Push(30);
                        stack.Push(56);
                        stack.IsEmpty();
                        break;
                    case 3:
                        queue.Enqueue(70);
                        queue.Enqueue(30);
                        queue.Enqueue(56);
                        queue.Display();
                        break;
                    case 4:
                        queue.Enqueue(70);
                        queue.Enqueue(30);
                        queue.Enqueue(56);
                        queue.Dequeue();
                        queue.Display();
                        break;
                    case 5:
                        end = false;
                        Console.WriteLine("Program Is Ended.");
                        break;
                    default:
                        Console.WriteLine("Enter The Correct Option");
                        break;

                }
            }
        }
    }
}