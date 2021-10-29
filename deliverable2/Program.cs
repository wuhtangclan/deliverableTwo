using System;

namespace deliverable2
{

    class Program
    {
        public static void Main(string[] args) {
            string again = "";

            Console.WriteLine("Oh you would like to speak with Computron? What would you like to say? (hello, hello there, sup or bye) ");
            string userInput = Console.ReadLine();
            userInput = userInput.ToLower();

            while (userInput != "bye")
            {

                if (userInput == again)
                {
                    Console.WriteLine("I'm sorry but you have already said that.");
                    Console.WriteLine("What else would you like to say to Computron?");
                    userInput = Console.ReadLine();
                    userInput = userInput.ToLower();
                }
                else if (userInput == "hello")
                {
                    Console.WriteLine("Hi good to see you.");
                    again = userInput;
                    Console.WriteLine("What else would you like to say to Computron?");
                    userInput = Console.ReadLine();
                    userInput = userInput.ToLower();
                }
                else if (userInput == "sup")
                {
                    Console.WriteLine("I am good.");
                    again = userInput;
                    Console.WriteLine("What else would you like to say to Computron?");
                    userInput = Console.ReadLine();
                    userInput = userInput.ToLower();
                }
                else if (userInput == "hello there")
                {
                    Console.WriteLine("General Kenobi");
                    again = userInput;
                    Console.WriteLine("What else would you like to say to Computron?");
                    userInput = Console.ReadLine();
                    userInput = userInput.ToLower();
                }
                else if (userInput == "bye")
                {
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again");
                }

            }
            Console.WriteLine("Good bye!");
        }

    }
}
