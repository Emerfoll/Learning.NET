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
            
            // Console.WriteLine("What number would you like to cube?");
            // int numberToCube = Convert.ToInt32(Console.ReadLine());

            // int cubedNumber = cubeThisNumber(numberToCube);

            // Console.WriteLine("beep boop calculating...");
            // Console.WriteLine("Here is the number you wanted cubed: " + cubedNumber);
            
            bool raining = false;

            if (raining) {
                Console.WriteLine("Bring an umbrella.");
            } else {
                Console.WriteLine("Don't forget your sunglasses!");
            }

            bool hungry = true;

            if (hungry) {
                Console.WriteLine("Grab some food on the way.");
            }


        }

        // static int cubeThisNumber(int numberToCube)
        // {
        //     int num3 = numberToCube * numberToCube * numberToCube;
        //     return num3;
        // }


    }
}
