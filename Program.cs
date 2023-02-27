using System.Collections.Generic;

namespace LinkedListProblems
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to Linked list problems");

            Console.WriteLine("Create linked list by appending 30 and 70 to 56");

            LinkedList linked = new LinkedList();
            linked.Append(56);
            linked.Append(30);
            linked.Append(70);

            linked.Display();
        }
    }
}
    