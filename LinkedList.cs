using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure
{
    public class LinkedList
    {
        public Node head;
        public void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into Linked list", node.data);
        }


        public int PopLast()
        {
            if (head == null)
            {
                Console.WriteLine("LinkedList is empty");
            }
            if (head.next == null)
            {
                head = null;
                return head.data;
            }
            Node newData = head;
            while (newData.next.next != null)
            {
                newData = newData.next;
            }
            int poppedElement = newData.next.data;
            newData.next = null;
            return poppedElement;
        }



        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
    }
}
