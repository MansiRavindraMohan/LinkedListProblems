using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblems
{
     public class LinkedList
    {
        public Node head;

        public void AddAtPosition(int position, int data)
        {
            Node newNode = new Node(data);

            if (position < 1)
            {
                Console.WriteLine("Invalid position");
            }
            if (position == 1)
            {
                newNode.next = head;
                head = newNode;
            }
            else
            {
                int currentPosition = 1;
                Node tempHead = head;
                while (currentPosition++ != position)
                {
                    if (currentPosition == position)
                    {
                        newNode.next = tempHead.next;
                        tempHead.next = newNode;
                        Console.WriteLine(newNode.data + " is added at position " + position);
                        break;
                    }
                    tempHead = tempHead.next;
                }
                if (currentPosition != position)
                {
                    Console.WriteLine("Position is out of range");
                }
            }
        }

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
            Console.WriteLine("{0} Added to linked list ", node.data);
        }

        internal void Pop()
        {
            if (head == null)
            {
                Console.WriteLine("Linked List is empty");
                return;
            }
            Console.WriteLine("The first node having data " + head.data + " is deleted from the list");
            head = head.next;
        }

        internal void PopLast()
        {
            Node newNode = head;
            if (head == null)
            {
                Console.WriteLine("Linked List is empty");
                return;
            }
            if (head.next == null)
            {
                this.head = null;
            }
            while (newNode.next.next != null)
            {
                newNode = newNode.next;
            }
            Console.WriteLine("The last node having data " + newNode.next.data + " is deleted from the list");
            newNode.next = null;
        }

        internal void Search(int value)
        {
            Node temp = this.head;
            while (temp != null)
            {
                if (temp.data == value)
                {
                    Console.WriteLine("Given value: " + value + " is present in Linked list");
                    return;
                }
                temp = temp.next;
            }
            if (temp == null)
                Console.WriteLine("Given value: " + value + " is not present in Linked list");
        }

        internal void InsertAfter(int value, int data)
        {
            Node tempHead = head;
            Node newNode = new Node(data);

            if (head == null)
            {
                Console.WriteLine("Linked List is empty");
                return;
            }

            while (tempHead.next != null)
            {
                if (tempHead.data == value)
                {
                    Console.WriteLine(newNode.data + " is inserted after " + tempHead.data);
                    newNode.next = tempHead.next;
                    tempHead.next = newNode;
                    break;
                }
                tempHead = tempHead.next;
            }
        }
        public void Display()
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
            Console.WriteLine();
        }
    }
}
