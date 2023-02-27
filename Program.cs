using System.Collections.Generic;

namespace LinkedListProblems
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to Linked list problems");

            LinkedList LL = new LinkedList();
            Console.WriteLine("Ordered linked list");
            LL.OrderedList(56);
            LL.OrderedList(30);
            LL.OrderedList(40);
            LL.OrderedList(70);
            Console.WriteLine("After sorting:");

            LL.Display();
        }
    }
}
    