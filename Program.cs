using System;
using System.Threading.Tasks.Dataflow;

namespace MainSpace;

    public class Program{
        public static void Main(string[] args)
        {
            Console.WriteLine("Choose options 1 or 2");
            Console.WriteLine("1 - > convert uzbek soum to dollar");
            Console.WriteLine("2 - > convert dollar to uzbek soum");

            string optionString  = Console.ReadLine();    
            float option = float.Parse(optionString); 

            decimal amountOfMoney = 0;
            decimal resultAmount = 0;

            if(option == 1){

                Console.WriteLine("Currently dollar course is 11600");
                Console.WriteLine("Enter the soum");

                amountOfMoney = decimal.Parse(Console.ReadLine());
                resultAmount = amountOfMoney / 11600    ;

                Console.WriteLine($"{amountOfMoney }soum is equal to {resultAmount} dollar");
                
            }
            else if(option == 2){
                Console.WriteLine("Currently dollar course is 11600");
                Console.WriteLine("Enter the dollar");

                amountOfMoney = decimal.Parse(Console.ReadLine());
                resultAmount = amountOfMoney * 11600    ;

                Console.WriteLine($"{amountOfMoney } dollar is equal to {resultAmount} soum");
            }
            else{
                Console.WriteLine("You have choosed wrong option, please try again");
            }
        
        }

    }
