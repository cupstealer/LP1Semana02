using System;

namespace ManipulaVar
{
    class Program
    {
        static void Main(string[] args)
    
        {
        
            string str = args[0];
            int x = int.Parse(str);
            int x2 = int.Parse(str);
            x++;
            --x2;
            Console.WriteLine(x);
            Console.WriteLine(x2);


        }
    }
}
