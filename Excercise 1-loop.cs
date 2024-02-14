using System;

class Program
{
    static void Main(string[] args)
    {
        int n; // Declaring it outside of the loop to acces the variable later

        // Loop until a valid number is entered
        while (true)
        {
            Console.WriteLine("Enter a number below 10:");
            // Reading the user input
            if (int.TryParse(Console.ReadLine(), out n) && n > 0 && n < 10)
            {
                // If the input is valid, breaking the loop
                break;
            }
            else
            {
                // If input is invalid, prompting the user to enter a valid number between 1 to 9
                Console.WriteLine("Invalid input. Please enter a number below 10.");
            }
        }

        // Displaying times table for the valid number
        Console.WriteLine($"Times table for {n}:");
        for (int i = 1; i <= 9; i++)
        {
            Console.WriteLine($"{i} * {n} = {i * n}");
        }
    }
}
