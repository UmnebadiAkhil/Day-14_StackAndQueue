// See https://aka.ms/new-console-template for more information

using System.Collections;
using System.Collections.Generic;
using Queue = DataStructureProblems_StacksAndQueues.Queue;
using Stack = DataStructureProblems_StacksAndQueues.Stack;

Console.WriteLine("Hello, World!");


bool flag = true;
while (flag)
{
    Console.WriteLine("\nEnter the program number which is to be executed \n 1.Stack, \n 2.Queue, \n 3.Exit");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            Stack stack = new Stack();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.Display();

            break;
        case 2:
            Queue queue = new Queue();
            queue.Enqueue(70);
            queue.Enqueue(30);
            queue.Enqueue(56);
            queue.Display();
            break;
        case 3:
            flag = false;
            break;
        
    }
}