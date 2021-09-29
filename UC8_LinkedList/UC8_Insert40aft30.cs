using System;
using System.Collections.Generic;
using System.Text;

namespace Day14LinkedList.UC8_LinkedList
{
    class UC8_Insert40aft30
    {
        internal Node head;
        internal void Add(int data)
        {
            Node node = new Node(data);
            if (this.head==null)
                this.head = node;
            else
            {
                Node temp = head;
                while(temp.next!=null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} insterd into Linked List", node.data);
        }
        internal void Display()
        {
            Node temp = this.head;
            if(head==null)
            {
                Console.Write("Linked list is Empty");
                return;
            }
            while(temp!=null)
            {
                Console.Write(temp.data+" ");
                temp = temp.next;
            }
        }
        internal Node InsertAtParticularPosition(int position, int data)
        {
            if (position < 1)
                Console.WriteLine("Invalid position");
            if (position == 1)
            {
                var newNode = new Node(data);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                Node temp = this.head;
                while (position-- != 0)
                {
                    Node node = new Node(data);
                    node.next = this.head.next;
                    head.next = node;
                    break;
                }
                temp = temp.next;
            }
            if (position != 1)
                Console.WriteLine("Position out of range");
                return head;
        }
        internal Node Search(int value)
        {
            while (this.head != null)
            {
                if (this.head.data == value)
                {
                    return this.head;
                }
                this.head = this.head.next;
            }
                return null;
        }
    }
}
