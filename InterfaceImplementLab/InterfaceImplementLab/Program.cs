using System;
interface IMyInterface
{
    void MyMethod();
}
class MyClass : IMyInterface
{
    public void MyMethod()
    {
        Console.WriteLine("Implementation of MyMethod in MyClass");
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyClass myObject = new MyClass();
        myObject.MyMethod();
    }
}
