using System;

namespace DASTRU_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"
--------------------------
AVERAGE CALCULATOR
--------------------------");

            Console.Write("Enter the number of values you want to compute: ");
            if (int.TryParse(Console.ReadLine(), out int numberOfValues) && numberOfValues > 0)
            {
                double[] numbers = new double[numberOfValues]; // Use an array of the specified size
                double sum = 0;

                for (int n = 0; n < numberOfValues; n++)
                {
                    Console.Write($"Enter value {n + 1}: ");
                    string input = Console.ReadLine();

                    if (double.TryParse(input, out double number))
                    {
                        numbers[n] = number; // Store the entered number in the array
                        sum += number; // Add the entered number to the sum
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        n--; // Decrement n to re-enter the current value
                    }
                }

                double average = sum / numberOfValues;
                Console.WriteLine($"Average of {numberOfValues} numbers is {average}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive integer for the number of values.");
            }
            while (true)
            {


                Console.Write("Do you want to Exit? Y/N: ");
                string ans = Console.ReadLine();

                if (ans == "Y")
                {
                    break;
                }
            }

        }
    }
}
