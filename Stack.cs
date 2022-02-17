using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    internal class Stack
    {
        public class StackOperation
        {
            Node top;
            public StackOperation()
            {
                this.top = null;
            }
            public void Push(int data)
            {
                Node newNode = new Node(data);
                if (top == null)
                {
                    newNode.next = null;
                }
                else
                {
                    newNode.next = top;
                }
                top = newNode;
                Console.WriteLine("{0} is pushed to stack ", data);
            }
            public void Display()
            {
                Node temp = this.top;
                if (temp == null)
                {
                    Console.WriteLine("Stack is empty");
                    return;
                }
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = (Node)temp.next;
                }
                Console.WriteLine();
            }
            public void Pop()
            {
                if (top == null)
                {
                    Console.WriteLine("stack is in underflow condition, Deletion is not possible");
                    return;
                }
                Console.WriteLine("{0} is deleted from stack", top.data);
                top = (Node)top.next;
            }
            public void Peek()
            {
                if (top == null)
                {
                    Console.WriteLine("stack is in undeflow condition");
                    return;
                }
                Console.WriteLine("{0} is on the top of the stack", top.data);
            }
        }
    }
}
