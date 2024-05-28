using System;
delegate int AddDelegate(int a, int b);

class Program
{
    static void Main(string[] args)
    {
        AddDelegate addDelegate = delegate (int x, int y)
        {
            return x + y;
        };
        Console.Write("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine());
        int result = addDelegate(num1, num2);
        Console.WriteLine($"Result of adding {num1} and {num2} is: {result}");
    }
}
