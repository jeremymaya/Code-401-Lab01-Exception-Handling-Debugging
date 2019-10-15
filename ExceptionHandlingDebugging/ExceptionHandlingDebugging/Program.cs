using System;

namespace ExceptionHandlingDebugging
{
    class Program
    {
        // Main calls the StartSequence method in the try block
        // If there is an error, catch block will display the Exception message
        // Once the application is finshed, it tells user that the program is completed
        static void Main(string[] args)
        {
            try
            {
                StartSequence();
            }
            catch (Exception e)
            {
                Console.WriteLine("It seems like there was an error.");
                Console.WriteLine("");
                Console.WriteLine(e.Message);
                Console.WriteLine("");
                Console.WriteLine("Press 'Enter' to continue.");
            }
            finally
            {
                Console.WriteLine("Program is complete.");
            }
        }
        static void StartSequence()
        {
            Console.WriteLine("Welcome to my game! Let's do some math!");
            Console.WriteLine("Please enter a number greater than zero");
            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);
            int[] numbers = new int[number];
            int[] populate = Populate(numbers);
            int sum = GetSum(populate);
            int product = GetProduct(populate, sum);
            decimal quotient = GetQuotient(product);
        }

        static int[] Populate(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Please enter number: {i + 1}/{arr.Length}");
                string input = Console.ReadLine();
                arr[i] = Convert.ToInt32(input);
            }
            return arr;
        }

        static int GetSum(int[] arr)
        {
            int num = 0;
            return num;
        }
        static int GetProduct(int[] arr, int num)
        {
            return num;
        }

        static decimal GetQuotient(int num)
        {
            decimal deci = 0;
            return deci;
        }
    }
}
