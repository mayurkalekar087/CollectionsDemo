using System;
using System.Collections.Generic; 
namespace CollectionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to c# Collections!");
            doStackDemo();
            doListDemo();
            doDictionary();
            doQueueDemo();
            doSetDemo();
        }
        private static void doStackDemo()
        {
            Console.WriteLine("\n1) In doStackDemo");
            //creating list
            Stack<string> stack = new Stack<string>();
            //Adding Objects to list
            stack.Push("Mayur");
            stack.Push("Sandeep");
            stack.Push("Kunal");
            stack.Push("Rohit");
            stack.Push("Ashish");
            string pop = stack.Pop();

            //iterating list element
            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("Popped element: " + pop);
        }

            private static void doListDemo()
        {
            Console.WriteLine("\n2) In doListDemo");
            //creating list
            List<string> list = new List<string>();
            //Adding Objects to list
            list.Add("Mayur");
            list.Add("Sandeep");
            list.Add("Kunal");
            list.Add("Rohit");

            //iterating list element
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }

        }
        private static void doDictionary()
        {
            Console.WriteLine("\n3) In doDictionaryDemo");

            Dictionary<int,string> dictionary = new Dictionary<int,string>();
            dictionary.Add(100, "Mayur");
            dictionary.Add(101, "Pratik");
            dictionary.Add(102, "Kunal");
            Console.WriteLine("Access value using key(key=100): " + dictionary[100]);

            Console.WriteLine("\n Iterating Dictionary");
            foreach (var element in dictionary)
            {
                Console.WriteLine("key = " + element.Key + "& Value =" + element.Value);
            }
        }
        private static void doQueueDemo()
        {
            Console.WriteLine("\n4) In doQueueDemo ");
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Amit Sharma");
            queue.Enqueue("vijay raj");
            queue.Enqueue("jaishankar");
            queue.Enqueue("Raj");
            Console.WriteLine("Head:" + queue.Peek());
            Console.WriteLine("\n Iterating the Queue elements");

            foreach (var element in queue)
            {
                Console.WriteLine(element);
            }
            string dequeue = queue.Dequeue();
            Console.WriteLine("Dequeue Element:" + dequeue);

            Console.WriteLine("\n Iterating the element after dequeue one element");
            Queue<string>.Enumerator enumerator = queue.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
        private static void doSetDemo()
        {
            Console.WriteLine("\n5) In doSetDemo");
            var set = new HashSet<string>();
            set.Add("Ravi");
            set.Add("vijay");
            set.Add("Ravi");
            set.Add("Ajay");
            HashSet<string>.Enumerator enumerator = set.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }

    }
}
