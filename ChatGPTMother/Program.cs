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
                Console.Write("What is your question? ");
                question = Console.ReadLine();

                switch (question)
                {
                case "How are you?":
                    response = "I feel amazing, thank you";
                    break;
                case "What's your name?":
                    response = "I'm Mother, nice to meet you! :) ";
                    break;
                case "How's your day?":
                    response = "It's been alright, but I feel better now since I have company!";
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
