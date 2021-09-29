using Day14LinkedList.UC3_LinkedList;
using System;
using System.Collections.Generic;
using System.Text;

namespace Day14LinkedList.UC3_LinkedList
{
    class UC3_Add30n70to56
    {
        internal Node head;
        internal void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
                this.head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into the linked list", node.data);
        }
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            while (temp != null)
            { 
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        internal Node Append(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = new Node(data);
                return head;
            }
            newNode.next = null;
            Node last = head;
            while (last.next != null)
            {
                last = last.next;
            }
            last.next = newNode;
            return newNode;
        }
    }
}
