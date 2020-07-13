using System;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Transactions;

namespace StudentInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            const int arrayLength = 11;
            string[] studentNames = {"Charlie", "Frank", "Mac", "Dennis", "Artemis", "Cricket", "Liam", "Ryan", "Waitress", "Dee", "Bill"};
            string[] studentFood = {"cheese", "rum ham", "beer", "pizza", "jagerbombs", "lemons", "milk", "milk", "coffee", "trash cake", "drugs" };
            string[] studentOldTitle = {"janitor", "The Warthog", "muscle", "psychopath", "drunk", "priest", "kidnapper", "Liam's shadow", "barista", "bird", "proud father" };

            bool continueFlag = true;
            Console.WriteLine("Welcome to our Dev.Build class!\n");


            while (continueFlag)
            {
                Console.Write("Would you like to see a list of students? (y for yes): ");
                string listAnswer = YesOrNo(Console.ReadLine());
                Console.WriteLine();

                if (listAnswer == "y")
                {
                    for (int i = 0; i < 11; i++)
                    {
                        Console.WriteLine($"{i + 1}. {studentNames[i]}");
                    }
                    Console.WriteLine();
                }
                else
                {
                    //HAHAHAHAHAHAHA
                }

                Console.Write($"Which student would you like to learn more about? (1-{arrayLength}): ");
                int userInput = IntValidation(Console.ReadLine()); 
                Console.WriteLine();


                bool validInput = false;
                while (!validInput)
                {
                    Console.WriteLine($"What would you like to know about {studentNames[userInput - 1]}?");
                    Console.Write("f for favorite food, or t for previous title: ");
                    string userAnswer = Console.ReadLine();
                    userAnswer = userAnswer.ToLower();
                    Console.WriteLine();

                    while (userAnswer != "f" && userAnswer != "t")
                    {

                        Console.Write("Please enter a valid selection (f/t): ");
                        userAnswer = Console.ReadLine();
                        userAnswer = userAnswer.ToLower();
                        Console.WriteLine();
                    }

                    if (userAnswer == "f" || userAnswer == "t")
                    {
                        switch (userAnswer)
                        {
                            case "f":
                                Console.WriteLine($"{studentNames[userInput - 1]}'s favorite food is {studentFood[userInput - 1]}.\n");
                                validInput = true;
                                break;
                            case "t":
                                Console.WriteLine($"{studentNames[userInput - 1]}'s previous title is {studentOldTitle[userInput - 1]}.\n");
                                validInput = true;
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        //HAHAHAHAHHAHAA
                    }

                    Console.Write($"Would you like to learn more about {studentNames[userInput - 1]} (y/n)?: "); // WOULD YOU LIKE TO KNOW MORE?!?!?!??!
                    string extra = YesOrNo(Console.ReadLine());
                    Console.WriteLine();

                    if (extra == "y")
                    {
                        switch (userAnswer) //switch the results of the previous switch to get the unknown info
                        {
                            case "t":
                                Console.WriteLine($"{studentNames[userInput - 1]}'s favorite food is {studentFood[userInput - 1]}.\n");
                                validInput = true;
                                break;
                            case "f":
                                Console.WriteLine($"{studentNames[userInput - 1]}'s previous title is {studentOldTitle[userInput - 1]}.\n");
                                validInput = true;
                                break;
                            default:
                                break;
                        }
                    }

                    Console.Write("Would you like to learn about a different student (y/n)?: "); // WOULD YOU LIKE TO KNOW MORE?!?!?!?!?!?!?
                    string cont = YesOrNo(Console.ReadLine());
                    Console.WriteLine();

                    if (cont == "n")
                    {
                        continueFlag = false;
                    }
                    else if (cont != "y")
                    {
                        //HAHAHAHA KEEP GOINGGGG!!!!!!!
                    }

                }
            }
            Console.WriteLine("OK BYEEEEEEEEE!!!!!!!!!\n\n\n\n\n");
        }

        private static string YesOrNo(string answer) //method to check (y/n)
        {
            answer = answer.ToLower();
            while (answer != "y" && answer != "n")
            {
                Console.Write("Please enter valid input (y/n): ");
                answer = Console.ReadLine();
                answer = answer.ToLower();
                Console.WriteLine();
            }

            return answer;
        }

        public static int IntValidation(string input) // data validation
        {
            int validIntOutput;
            while (!int.TryParse(input, out validIntOutput) || validIntOutput < 1 || validIntOutput > 11) //manually set range
            {
                Console.WriteLine($"\nPlease enter a 1 through 11");
                Console.Write("Try again please: ");
                input = Console.ReadLine();
            }
            return validIntOutput;
        }
    }
}
