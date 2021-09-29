using System;
using System.Collections.Generic;
using System.Text;

namespace Day14LinkedList.UC10_LinkedList
{
    class UC10_SortedLinkedList
    {
        
        internal Node head;
        internal Node1 head1;
        internal void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
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
            Console.WriteLine("{0} inserted into LinkedList", node.data);
        }
        internal void Display()
        {
            Node temp = this.head;
            if(temp==null)
            {
                Console.WriteLine("Linked List empty");
                return;
            }
            while(temp!=null)
            {
                Console.WriteLine(  temp.data+" ");
                temp = temp.next;
            }
        }
        internal void Sort(int Value)
        {
            Node1 newNode = new Node1(Value);
            Node1 temp11;
            if (head == null || head.data >= newNode.data)
            {
                newNode.next = head1;
                head1 = newNode;
            }
            else
            {
                temp11 = head1;
                while(temp11.next!=null && temp11.next.data<newNode.data)
                {
                    temp11 = temp11.next;
                }
                newNode.next = temp11.next;
                temp11.next  = newNode;
            }
        }

    }
}
