using System;

namespace Learning.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lets make a MadLib

            // string color, pluralNoun, celebrity;

            // Console.Write("Enter a color: ");
            // color = Console.ReadLine();

            // Console.Write("Enter a plural noun: ");
            // pluralNoun = Console.ReadLine();

            // Console.Write("Enter a celebrity name: ");
            // celebrity = Console.ReadLine();

            // Console.WriteLine("Roses are " + color);
            // Console.WriteLine(pluralNoun + " are blue");
            // Console.WriteLine("I love " + celebrity);


            // learning arrays

            // int[] luckyNumbers = {11, 13, 19, 42};
            
            // Console.WriteLine(luckyNumbers[3]);
            
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            sayHello(name);

        }

        static void sayHello(string name)
        {
            Console.WriteLine("Hello " + name + "!");

        }


    }
}
