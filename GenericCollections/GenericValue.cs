using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCollections
{
    public class GenericValues<T>
    {
        public HashSet<T> Hashset;
        public static void HashSetValues()
        {
            HashSet<string> customers = new HashSet<string>();
            foreach (string customer in new string[5] { "James","Monica","Joey","Frank","Francesca"})
            {
                customers.Add(customer);
                Console.WriteLine(customer);
            }
        }

        public static void ListValues()
        {
            List<string> animals = new List<string>();
            foreach (string animal in new string [5] {"aardvark","buffalo","cheetah","zebra","mongoose" })
            {
                animals.Add(animal);
                Console.WriteLine(animal);
            }
        }
        public static void LinkedListValues()
        {
            LinkedList<int> numbers = new LinkedList<int>();
            foreach (int number in new int[5] { 1, 300, 5678, 98764, 1235752 })
            {
                numbers.AddFirst(number);
                Console.WriteLine(number);
            }
        }
        public static void QueueValues()
        {
            Queue<string> tickets = new Queue<string>();
            foreach (string ticket in new string[5] { "Movie Ticket", "Arcade Ticket","Concert Ticket", "Plane Ticket", "Sports Ticket"})
            {
                tickets.Enqueue(ticket);
                Console.WriteLine(ticket);
            }
        }
        public static void StackValues()
        {
            Stack<string> employees = new Stack<string>();
            foreach (string employee in new string[5] {"John Hancock", "John Wilcox", "Johny Appleseed", "Johnathan Grames", "Jillian Millian" })
            {
                employees.Push(employee);
                Console.WriteLine(employee);
            }
        }
        public static void DictionaryValues()
        {
            Dictionary<int, string> passwords = new Dictionary<int, string>();
            passwords.Add(1, "pasSW0rd");
            passwords.Add(2, "Ilov3D0gZ");
            passwords.Add(3, "081912_D0G_Lov3r");
            passwords.Add(4, "1234USmAr1n3C0rpS");
            passwords.Add(5, "Ilov3D0gZ2");
            foreach (var password in passwords)
            {
                Console.WriteLine(password);
            }
        }
        public static void SortedListValues()
        {
            SortedList<string, int> ages = new SortedList<string, int>();
            ages.Add("Juan", 24);
            ages.Add("Claudia", 44);
            ages.Add("Maria", 21);
            ages.Add("Isabella", 13);
            ages.Add("JC", 53);
            foreach (var age in ages)
            {
                Console.WriteLine(age);
            }
        }
    }
}
