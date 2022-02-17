using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    internal class Queue
    {
        Node front;
        Node rear;
        public Queue()
        {
            this.front = this.rear = null;
        }
        public void Enqueue(int data)
        {
            Node newNode = new Node(data);
            if (this.rear == null)
            {
                this.front = this.rear = newNode;
            }
            else
            {
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
                temp = (Node)temp.next;
            }
            Console.WriteLine();
        }
        public void Dequeue()
        {
            if (this.front == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            Node temp = this.front;
            this.front = (Node)this.front.next;

            if (this.front == null)
            {
                this.rear = null;
            }
            Console.WriteLine("{0} is deleted from the Queue", temp.data);
        }
    }
}
