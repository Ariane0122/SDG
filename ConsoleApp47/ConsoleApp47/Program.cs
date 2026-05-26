using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp47
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating a dictionary
            Dictionary<int, string> sub = new Dictionary<int, string>();

            // Adding elements
            sub.Add(1, "C#");
            sub.Add(2, "Javascript");
            sub.Add(3, "Dart");

            // Displaying dictionary
            foreach (var ele in sub)
            {
                Console.WriteLine($"Key: {ele.Key}, Value: {ele.Value}");
            }

            Console.WriteLine();

            Dictionary<int, string> dict = new Dictionary<int, string>();

            // Adding key-Value pairs
            dict.Add(1, "Welcome");
            dict.Add(2, "to");
            dict.Add(3, "GeeksforGeeks");

            // Displaying the dictionary
            foreach (KeyValuePair<int, string> ele in dict)
            {
                Console.WriteLine("key: {0} and value: {1}", ele.Key, ele.Value);
            }

            Stack<int> s = new Stack<int>();

            // Push elements onto the stack
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push(4); 
            s.Push(5);

            // Pop elements from the stack
            while (s.Count > 0)
            {
                Console.WriteLine(s.Pop());
            }
        }
    }
}
