using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresDemo
{
    public class LinkedList
    {
        internal Node head;
        internal void Add(int data)
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
            Console.WriteLine("{0} inserted into linked list", node.data);
        }
        internal void AddInReverseOrder(int data)
        {
            Node newNode = new Node(data);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node temp = this.head; //70
                head = newNode; //30
                head.next = temp; //30---->70
            }
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
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }

        internal void InsertAtParticularPosition(int position, int data) //1,30
        {
            Node newestNode = new Node(data);
            if (this.head == null)
            {
                this.head = newestNode;
            }
            if (position == 0)
            {
                newestNode.next = this.head;
                this.head = newestNode;
                return;
            }
            Node prev = null;
            Node current = this.head;
            int count = 0;
            while (current != null && count < position)
            {
                prev = current;
                current = current.next;
                count++;
            }
            newestNode.next = prev.next;
            prev.next = newestNode;
        }

        internal void RemoveFirstNode()
        {
            if (this.head == null)
            {
                Console.WriteLine("linkedList is empty");
            }
            this.head = this.head.next;
        }

        internal void RemovelastNode()
        {
            if (head == null)
            {
                Console.WriteLine("LinkedList is empty");
            }
            if (head.next == null)
            {
                this.head = null;
            }
            Node NewNode = head;
            while (NewNode.next.next != null)
            {
                NewNode = NewNode.next;
            }
            NewNode.next = null;

        }

        internal void Search(int value)
        {
            Node node = this.head;
            int count = 0;
            while (node != null)
            {
                if (node.data.Equals(value))
                {
                    Console.WriteLine(count);
                }
                node = node.next;
                count++;
            }
        }
        internal void DeleteNodeAtParticularPosition(int position) //2
        {
            if (this.head == null)
            {
                Console.WriteLine("LinkedList is empty");
            }
            if (head.next == null)
            {
                this.head = null;
            }
            Node NewNode = head;
            while (NewNode.next.next != null)
            {
                NewNode = NewNode.next;
            }
            NewNode.next = null;

        }








    }
}
