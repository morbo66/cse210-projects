using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep5 World!");

        DisplayWelcome();
        string userName = PromptUserName();
        int favNum = PromptUserNumber();
        favNum = SquareNumber(favNum);
        DisplayResult(userName, favNum);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userInput = Console.ReadLine();
        return userInput;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string userInput = Console.ReadLine();
        int userNum = int.Parse(userInput);
        return userNum;
    }

    static int SquareNumber(int num)
    {
        num = num * num;
        return num;
    }

    static void DisplayResult(string userName, int favNum)
    {
        Console.WriteLine($"{userName}, the square of your number is {favNum}.");
    }

}