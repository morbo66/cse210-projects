using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep2 World!");

        Console.WriteLine();
        Console.Write("What is your grade? ");
        string input = Console.ReadLine();
        int percent = int.Parse(input);
        string letter;
        if (percent < 60)
        {
            letter = "n F";
        }
        else if (percent < 70)
        {
            letter = " D";
        }
         else if (percent < 80)
        {
            letter = " C";
        }
         else if (percent < 90)
        {
            letter = " B";
        }
        else
        {
            letter = "n A";
        }
           
        Console.WriteLine();
        Console.WriteLine($"You recieved a{letter} in your class.");
        if(percent >= 70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else
        {
            Console.WriteLine("I'm sorry, you failed. There's always next semester.");
        }
        Console.WriteLine();
        


    }
}