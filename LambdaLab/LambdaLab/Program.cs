using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<string> fruits = new List<string> { "apple", "banana", "apricot", "orange", "avocado" };
        List<string> result = fruits.Where(fruit => fruit.StartsWith("a")).ToList();
        Console.WriteLine("Fruits whose names start with 'a':");
        foreach (string fruit in result)
        {
            Console.WriteLine(fruit);
        }
    }
}
