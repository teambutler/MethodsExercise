using System;

namespace Method_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Name : David
            //Favorite Color: Turquoise
            //Favorite Animal: Lions
            //Favorite Band: OUTKAST
            
            
            Console.WriteLine($"Hello - What is your first name?");
            var name = Console.ReadLine();

            Console.WriteLine($"Hi {name}, What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"{color} is a cool color!, now what is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine($"{animal} are ferocious and should not be played with. What is your favorite music band?");
            var band = Console.ReadLine();

        }
    }
}
