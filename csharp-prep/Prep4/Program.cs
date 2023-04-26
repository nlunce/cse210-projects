using System;
using System.Collections.Generic;


class Program
{
    static void ListOperations(){

        List<int> numbers = new List<int>();
        int number = 1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.Write("Enter number: ");
        number = int.Parse(Console.ReadLine());
        if(number != 0)
            {
                numbers.Add(number);
            }


        while(number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            
            if(number != 0)
            {
                numbers.Add(number);
            }
        }

        int length = 0;
        foreach (int i in numbers)
        {
            length ++;
        }

        int sum = numbers.Sum();
        float average = sum / length;


        int largestNumber = 0;

        foreach (int i in numbers)
        {
            if(i > largestNumber)
            {
                largestNumber = i;
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");
       

    }
    static void Main(string[] args)
    {
        ListOperations();

    }
}