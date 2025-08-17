using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Predefined test values
        double weight = 40;
        double width = 10;
        double height = 12;
        double length = 11;

        Console.WriteLine($"Package weight: {weight}");
        Console.WriteLine($"Package dimensions (W x H x L): {width} x {height} x {length}");

        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return;
        }

        if ((width + height + length) > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return;
        }

        double quote = (width * height * length * weight) / 100;
        Console.WriteLine($"Your estimated total for shipping this package is: ${quote:0.00}");
        Console.WriteLine("Thank you!");
    }
}
