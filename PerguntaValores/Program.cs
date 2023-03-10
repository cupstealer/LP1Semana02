using System;

namespace PerguntaValores
{
    class Program
    {
        static void Main(string[] args)

        {
            float height, radius;
            double volume;

            Console.WriteLine("Insert the object's height: ");
            height = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert the object's radius: ");
            radius = int.Parse(Console.ReadLine());

            volume = Math.PI*Math.Pow(radius, 2)*height;
            Console.WriteLine("The cylinder volume: " + volume);
            Console.WriteLine();

        }
    }
}
