using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep1 World!");
        //Assignment Number 1
        Console.WriteLine("What is your first name? ");
        string first = Console.ReadLine();

        Console.WriteLine("What is your last name? ");
        string last = Console.ReadLine();

        Console.WriteLine($"Your name is {last}, {first} {last}. ");

    }
}