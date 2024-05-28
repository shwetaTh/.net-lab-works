﻿using System;
class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating");
    }
}
class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog();
        dog.Eat();
        dog.Bark();
    }
}
