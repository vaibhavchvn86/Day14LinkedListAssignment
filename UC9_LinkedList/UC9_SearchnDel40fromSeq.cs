using System;
using System.Collections.Generic;
using System.Text;

namespace Day14LinkedList.UC9_LinkedList
{
    class UC9_SearchnDel40fromSeq
    {
        public Node head;
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
            Console.WriteLine("{0} inserted into LinkedList",node.data);
        }
        
        internal Node Search(int value)
        {
            Node temp = this.head;
            while(temp != null)
            {
            if(temp.data==value)
                {
                    Console.WriteLine("\n Your element found");
                    return temp;
                }
                temp = temp.next;
            }
            return null;
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
                while (position-- != 0) //
                {
                    if (position == 1)
                    {
                        Node node = new Node(data);
                        node.next = this.head.next;
                        head.next = node;
                        break;
                    }
                    temp = temp.next;//1000
                }
                if (position != 1)
                    Console.WriteLine("Position out of range");
            }
            return head;
        }
        internal void Delete(int value)
        {
            Node temp = head, prev = null;
            if (temp != null && temp.data == value)
            {
                head = temp.next;
                return;
            }
            while (temp != null && temp.data != value)
            {
                prev = temp;
                temp = temp.next;
            }
            if (temp == null)
                return;
            prev.next = temp.next;
        }
            internal void Display()
            {
                Node temp = this.head;
                if (temp == null)
                {
                    Console.WriteLine("LinkedList is empty");
                    return;
                }
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
            }
        public int Count()
        {
            Node temp = head;
            int count = 0;
            while(temp!=null)
            {
                count++;
                temp = temp.next;
            }
            return count;
        }
    }
}
