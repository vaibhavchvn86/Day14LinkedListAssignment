using System;

namespace Day14LinkedList.UC7_LinkedList
{
    class UC7_Search30
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
            Console.WriteLine("{0} insterd into Linked List", node.data);
        }
        internal void Display()
        {
            Node temp = this.head;
            if (temp==null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            while(temp!=null)
            {
                Console.Write(temp.data+" ");
                temp = temp.next;
            }
        }
        internal Node Search(int value)
        {
            Node temp = this.head;
            while (temp != null)
            {
                if (temp.data == value)
                {
                    Console.WriteLine("\n Your Element found");
                    return temp;
                }
                temp = temp.next;
            }
            return null;
        }
    }
}
