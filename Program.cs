using System;

class Program
{
    static void Main()
    {
        // Display welcome message at the start of the program
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Ask user for the package weight
        Console.Write("Please enter the package weight: ");
        double weight = Convert.ToDouble(Console.ReadLine());

        // If weight is greater than 50, display error and exit program
        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return; // Program ends here
        }

        // Ask user for the package width
        Console.Write("Please enter the package width: ");
        double width = Convert.ToDouble(Console.ReadLine());

        // Ask user for the package height
        Console.Write("Please enter the package height: ");
        double height = Convert.ToDouble(Console.ReadLine());

        // Ask user for the package length
        Console.Write("Please enter the package length: ");
        double length = Convert.ToDouble(Console.ReadLine());

        // If sum of dimensions is greater than 50, display error and exit program
        if ((width + height + length) > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return; // Program ends here
        }

        // Calculate shipping quote:
        // Multiply dimensions (width * height * length)
        // Then multiply by weight
        // Divide by 100 for final cost
        double quote = (width * height * length * weight) / 100;

        // Display the result formatted as a dollar amount with 2 decimal places
        Console.WriteLine($"Your estimated total for shipping this package is: ${quote:0.00}");
        Console.WriteLine("Thank you!");
    }
}
