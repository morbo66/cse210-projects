using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep4 World!");
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();
        
        int input;
        do
        {
            Console.Write("Enter a number: ");
            string inputString = Console.ReadLine();
            input = int.Parse(inputString);
            if (input != 0 )
            {
                numbers.Add(input);
            }
        }while (input != 0);

        int total = 0;
        int largest = numbers[0];

        foreach (int num in numbers)
        {
            total += num;
            if (num > largest)
            {
                largest = num;
            }
        }
        float average = (float)total / numbers.Count;
        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}