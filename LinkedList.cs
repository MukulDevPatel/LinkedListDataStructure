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

        public Node Search(int targetValue)
        {
            Node newNode = head;
            while (newNode != null)
            {
                if (newNode.data == targetValue)
                {
                    return newNode;
                }
                newNode = newNode.next;
            }
            return null;
        }


        public void InsertNumAtParticularPosition(int targetValue, int newData)
        {
            Node targetNode = Search(targetValue);
            if (targetNode != null)
            {
                Node newNode = new Node(newData);
                newNode.next = targetNode.next;
                targetNode.next = newNode;
            }
        }

        public void Remove(int targetValue)
        {
            if (head == null)
            {
                Console.WriteLine("There is no value");
            }
            if (head.data  == targetValue)
            {
                head = head.next;
                return;
            }
            Node currentNode = head;
            while (currentNode.next != null)
            {
                if (currentNode.next.data == targetValue)
                {
                    currentNode.next = currentNode.next.next;
                    return;
                }
                currentNode = currentNode.next;
            }
        }

        public int Size()
        {
            int count = 0;
            Node current = head;
            while (current != null)
            {
                count++;
                current = current.next;
            }
            return count;
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
