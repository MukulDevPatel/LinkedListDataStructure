using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure
{
    public class SortedLinkedList<T> where T : IComparable<T>
    {
        public Node<T> head;
        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);
            if (this.head == null || data.CompareTo(head.data) < 0)
            {
                node.next = head;
                head = node;
            }
            else
            {
                Node<T> temp = head;
                while (temp.next != null && temp.next.data.CompareTo(data) < 0)
                {
                    temp = temp.next;
                }
                node.next = temp.next;
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into Linked list", node.data);
        }

        public void Display()
        {
            Node<T> temp = this.head;
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
            Console.WriteLine();
        }
    }
}
