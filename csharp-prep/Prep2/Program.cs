using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        int onesPlace = percent % 10;
        string sign = "";

        if(onesPlace >= 7)
        {
            sign = "+";
        }
        else if(onesPlace >= 3 && onesPlace < 7)
        {
            sign = "";
        }
        else
        {
            sign = "-";
        }

        if(letter == "F" || (letter == "A" && sign == "+") || percent == 100){
            sign = "";

        }

        Console.WriteLine($"Your grade is: {letter}{sign}");
        
        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }


    }
}
    
