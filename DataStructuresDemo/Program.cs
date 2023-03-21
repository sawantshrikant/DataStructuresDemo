using System;
using System.Collections.Generic;

namespace DataStructuresDemo
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Data Structures Problem!");
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            Console.WriteLine("Nodes in the list:");
            list.Display();

            list.AddInReverseOrder(70);

            Console.WriteLine("\nNodes after adding node in reverse order:");
            list.Display();

            // node at a particular position
             list.InsertAtParticularPosition(1, 25);

            Console.WriteLine("\nNodes after inserting node at position 1:");
            list.Display();

            // Remove first node
            list.RemoveFirstNode();

            Console.WriteLine("\nNodes after removing first node:");
            list.Display();

            // Remove last node
            list.RemovelastNode();

            Console.WriteLine("\nNodes after removing last node:");
            list.Display();







        }
    }
}
