﻿using System;
namespace LinkedListStackAndQueue
{
    class program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("-----------Welcome to Linked List Program----------");
            bool end = true;
            Console.WriteLine("\n1.StackPush\n2.StackPickPop\n3.End Of Program ");
            while (end)
            {
                LinkedListStack stack = new LinkedListStack();
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