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
            Console.WriteLine(sum);
            int product = GetProduct(populate, sum);
            
            GetQuotient(product);
            
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
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            if (sum > 20)
            {
                return sum;

            }
            else
            {
                throw (new Exception($"Value of {sum} is too low."));
            }
        }
        static int GetProduct(int[] arr, int num)
        {
            Console.WriteLine($"Please select a random number between 1 and {arr.Length}");
            string input = Console.ReadLine();

            try
            {
                int product = num * arr[Convert.ToInt32(input) - 1];
                return product;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static decimal GetQuotient(int num)
        {
            Console.WriteLine($"Please enter a number to divde your product {num} by");
            string input = Console.ReadLine();
            try
            {
                decimal quotient = decimal.Divide(num, Convert.ToInt32(input));
                return quotient;
            }
            catch()
            {
                return 0;
            }
        }
    }
}
