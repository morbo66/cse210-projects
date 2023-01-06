using System;

class Program
{
    static void Main(string[] args)
    {
        //get first name

        Console.WriteLine();
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();
        
        //get last name
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        //print last name first name last name
        Console.WriteLine();
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
        Console.WriteLine();
    }
}