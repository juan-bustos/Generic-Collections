using System;

namespace GenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List Values:");
            GenericValues<object>.ListValues();

            Console.WriteLine("\n\nLinked List Values:");
            GenericValues<object>.LinkedListValues();

            Console.WriteLine("\n\nQueue Values:");
            GenericValues<object>.QueueValues();

            Console.WriteLine("\n\nStack Values:");
            GenericValues<object>.StackValues();

            Console.WriteLine("\n\nDictionary Values:");
            GenericValues<object>.DictionaryValues();

            Console.WriteLine("\n\nSorted List Values:");
            GenericValues<object>.SortedListValues();

            Console.WriteLine("\n\nHash Set Values:");
            GenericValues<object>.HashSetValues();
        }
    }
}
