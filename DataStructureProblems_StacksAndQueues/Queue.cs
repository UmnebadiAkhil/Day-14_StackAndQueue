using MyLinkedListProblems;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems_StacksAndQueues
{
   
    public class Queue
    {
        Node front;
        Node rear;
        public Queue()
        {
            this.front = this.rear = null;
        }
        internal void Enqueue(int data)
        {
            Node newNode = new Node(data);
            // If queue is empty, then new node is front and rear both 
            if (this.rear == null)
            {
                this.front = this.rear = newNode;
            }
            else
            {
                // Add the new node at the end of queue and change rear
                this.rear.next = newNode;
                this.rear = newNode;
            }
            Console.WriteLine("{0} is inserted into Queue", data);
        }
        public void Display()
        {
            Node temp = this.front;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
    }
}
