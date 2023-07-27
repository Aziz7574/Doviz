using System;
using System.Threading.Tasks.Dataflow;

namespace MainSpace;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Choose option 1 or 2");
        Console.WriteLine("1 - > convert uzbek soum to dollar");
        Console.WriteLine("2 - > convert dollar to uzbek soum");

        string optionString = Console.ReadLine();

        decimal amountOfMoney = 0;
        decimal resultAmount = 0;

        if (optionString == "1")
        {

            Console.WriteLine("Currently dollar course is 11600");
            Console.WriteLine("Enter the soum");

            amountOfMoney = decimal.Parse(Console.ReadLine());
            resultAmount = amountOfMoney / 11600;

            Console.WriteLine($"{amountOfMoney} soum is equal to {resultAmount} dollar");
        }
        else if (optionString == "2")
        {
            Console.WriteLine("Currently dollar course is 11600");
            Console.WriteLine("Enter the dollar");

            amountOfMoney = decimal.Parse(Console.ReadLine());
            resultAmount = amountOfMoney * 11600;

            Console.WriteLine($"{amountOfMoney} dollar is equal to {resultAmount} soum");
        }

        Console.WriteLine("Press 1 to continue or anything to quit");
        
        string option = Console.ReadLine();
        if (option == "1")
            Main(args);
        else return;

        Console.WriteLine("That is it");

    }

}
