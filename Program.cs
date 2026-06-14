using System;

namespace DivisionAndConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Division and Conversion Calculator ---");
            
            // Prompt user for input
            Console.Write("Enter the first number (numerator): ");
            string input1 = Console.ReadLine();

            Console.Write("Enter the second number (denominator): ");
            string input2 = Console.ReadLine();

            // Call the method to process the inputs
            Divide(input1, input2);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        public static void Divide(string num1Str, string num2Str)
        {
            try
            {
                // Convert strings to integers
                int num1 = Convert.ToInt32(num1Str);
                int num2 = Convert.ToInt32(num2Str);

                // Perform division
                int result = num1 / num2;

                // Print the successful result
                Console.WriteLine($"\nSuccess! {num1} / {num2} = {result}");
            }
            catch (FormatException)
            {
                // Handles non-integer inputs (e.g., typing "five")
                Console.WriteLine("\nError: Invalid input format. Please enter valid integers only.");
            }
            catch (DivideByZeroException)
            {
                // Handles division by zero
                Console.WriteLine("\nError: Cannot divide by zero. Please enter a non-zero denominator.");
            }
            catch (OverflowException)
            {
                // Handles numbers that exceed Int32 boundaries
                Console.WriteLine("\nError: The number entered is too large or too small for an integer.");
            }
            catch (Exception ex)
            {
                // Catches any other unforeseen exceptions and displays debugging info
                Console.WriteLine($"\nAn unexpected error occurred: {ex.Message}");
            }
        }
    }
}
