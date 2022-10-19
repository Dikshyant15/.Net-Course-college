using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Calculator
{
    internal class userProgram
    {
         class Operations {
            public static void Additon(int n1, int n2)
            {
                Console.WriteLine($"The sum of {n1} and {n2} is: {n1 + n2}");

            }
            public static void Subtraction(int n1, int n2)
            {
                Console.WriteLine($"The difference between {n1} and {n2} is: {n1 - n2}");
            }

            public static void Multiplication(int n1, int n2)
            {
                Console.WriteLine($"The product of {n1} and {n2} is: {n1 * n2}");
            }

            public static void Division(int n1, int n2)
            {
                Console.WriteLine($"{n1} divided by {n2} results to: {n1 / n2}");
            }
        }
       
        public static void Calculations() {
            string userChoice = "yes";
            int[] userInput = new int[2];

            while (userChoice=="yes") {
                Console.WriteLine("Choose an option from the following list:");
                Console.WriteLine("Press 1 for Addition");
                Console.WriteLine("Press 2 for Subtraction");
                Console.WriteLine("Press 3 for Multiplication");
                Console.WriteLine("Press 4 for Division");
                Console.WriteLine("Press 5 for Jagged Arrays");
                Console.WriteLine("Press 6 for SingleDimensional Arrays");
                Console.WriteLine("Press 7 for ImplicitlyTyped Arrays");
                Console.WriteLine("Press 8 for MultiDimensional Arrays");
                Console.Write("Your option? ");

                switch (Console.ReadLine()) {
                    case "1":
                        userInput = inputQuery.UserQuery();
                        Operations.Additon(userInput[0], userInput[1]);
                        break;

                    case "2":
                        userInput = inputQuery.UserQuery();
                        Operations.Subtraction(userInput[0], userInput[1]);
                        break;

                    case "3":
                        userInput = inputQuery.UserQuery();
                        Operations.Multiplication(userInput[0], userInput[1]);
                        break;

                    case "4":
                        userInput = inputQuery.UserQuery();
                        Operations.Division(userInput[0], userInput[1]);
                        break;

                    default:
                        Console.WriteLine("Re-run Program");
                        return;


                }

                do
                {
                    Console.Write("Do you want to continue?[yes/no]: ");
                    userChoice = Console.ReadLine().ToLower();

                } while (!(userChoice == "yes" || userChoice == "no"));


            }
        
        }
    }
}
