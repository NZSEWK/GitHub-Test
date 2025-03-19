using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter a 3: ");
            int numerator = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a 4: ");
            int denominator = Convert.ToInt32(Console.ReadLine());

            int result = numerator / denominator;
            Console.WriteLine($"Result: {result}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: You cannot divide by zero.");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Error: Please enter a valid number.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("End of program.");
        }
    }
}
