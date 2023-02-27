using System.Collections.Generic;

namespace LinkedListProblems
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to Linked list problems");

            Console.WriteLine("Insert 30 between 56 and 70");

            LinkedList linked = new LinkedList();
            linked.Add(56);
            linked.Add(30);
            linked.Add(70);
            linked.Display();

            linked.DeleteValue(40);
            linked.Display();
            linked.Size();

        }
    }
}
    