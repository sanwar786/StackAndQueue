using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    internal class LinkdList
    {
        Node head;
        public void Add(int newData)
        {
            Node newNode = new Node(newData);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = (Node)temp.next;
                }
                temp.next = newNode;
            }
            Console.Write("\n {0} inserted into linked list", newNode.data);
        }
        public void AddinreverseOrder(int newData)
        {
            Node newNode = new Node(newData);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node temp = this.head;
                head = newNode;
                head.next = temp;
            }
            Console.Write("\n {0} inserted into linked list", newNode.data);
        }
        public void Display()
        {
            Console.Write("\n Data of linked list : ");
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }

            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = (Node)temp.next;
            }
        }
        public Node InsertAtParticularPosition(int position, int data)
        {
            Node neweNode = new Node(data);
            if (this.head == null)
            {
                return neweNode;
            }
            if (position == 0)
            {
                neweNode.next = this.head;
                this.head = neweNode;
                return this.head;
            }
            Node prev = null;
            Node current = this.head;
            int count = 0;
            while (current != null && count < position)
            {
                prev = current;
                current = (Node)current.next;
                count++;
            }
            neweNode.next = prev.next;
            prev.next = neweNode;
            return this.head;
        }
        public Node DeleteFirstNode()
        {
            if (this.head == null)
            {
                return null;
            }
            this.head = (Node)this.head.next;
            return this.head;
        }
        public Node DeleteLastNode()
        {
            if (head == null)
            {
                return null;
            }
            if (head.next == null)
            {
                return null;
            }
            Node newNode = head;
            while (newNode.next != null)
            {
                newNode = (Node)newNode.next;
            }
            newNode.next = null;
            return head;
        }
        public int Search(int value)
        {
            Node node = this.head;
            int count = 0;
            while (node != null)
            {

                if (node.data != null)
                {
                    node = (Node)node.next;
                    count++;
                }
                else
                {
                    return count;
                }
            }
            return count;
        }
        public void DeleteNodeAtParticularPosition(int position)
        {
            if (this.head == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            Node temp = this.head;
            if (position == 0)
            {
                this.head = (Node)temp.next;
                return;
            }
            for (int i = 0; temp != null && i < position - 1; i++)
            {
                temp = (Node)temp.next;

            }
            if (temp == null || temp.next == null)
            {
                return;
            }
            Node next = (Node)temp.next;
            temp.next = next;
            Size();
        }
        public void Size()
        {
            Node temp = this.head;
            int count = 0;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = (Node)temp.next;
                count++;
            }
            Console.WriteLine("\nLength of LinkedList is :- " + " " + count);
        }
    }
}
