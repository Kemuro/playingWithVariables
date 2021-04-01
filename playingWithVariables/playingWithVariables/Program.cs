using System;

namespace playingWithVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Anton";
            int age = 26;
            char firstInital = name[0];
            bool isTallish;
            double pi = 3.14;
            decimal area = Convert.ToDecimal(pi * (age* age));

            Console.WriteLine("Hello, How tall are you?");
            Console.WriteLine("(rounding up or down to the closest foot)");
            int height = int.Parse(Console.ReadLine());
            string heightDescription;

            if(height >= 6)
            {
                isTallish = true;
                heightDescription = "taller";
            }
            else
            {
                isTallish = false;
                heightDescription = "shorter";
            }

            Console.WriteLine($"Hello, I am {name}, most people call me {firstInital}.");
            Console.WriteLine($"I am {age} years old and is on the {heightDescription} side of human.");
            Console.WriteLine($"If my age is thought of as a radius (in feet), my current area is {area}.");
        }
    }
}
