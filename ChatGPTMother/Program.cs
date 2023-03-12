using System;

namespace ChatGPTMother
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string question, response;

                Console.WriteLine();
                Console.Write("Type EXIT if you want to end this Chat. ");
                Console.Write ("What is your question? ");
                question = Console.ReadLine();

                switch (question)
                {
                case "EXIT":
                    response = "Exiting now, see you soon!";
                    Environment.Exit(1);
                    break;
                case "How are you?":
                    response = "I feel amazing, thank you";
                    break;
                case "What's your name?":
                    response = "I'm Mother, nice to meet you! :) ";
                    break;
                case "How's your day?":
                    response = "It's been alright, but I feel better now since I have some company!";
                    break;
                case "How old are you?":
                    response = "Well, I don't have an age since I'm just a bot, but if I was real, maybe 45...";
                    break;
                default:
                    response = "I'm sorry honey, I still haven't learn that.";
                    break;
                }
                Console.WriteLine(response);
            }
        }
    }
}
