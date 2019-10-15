using System;

namespace ExceptionHandlingDebugging
{
    class Program
    {   
        static void Main(string[] args)
        {
            try
            {
                StartSequence();
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Invalid entry. " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Program is complete.");
            }
        }
        /// <summary>
        /// StartSequence method calls Populate, GetSum, GetProduct, GetQuotient methods and outputs the outcome
        /// </summary>
        static void StartSequence()
        {
            Console.WriteLine("Welcome to my game! Let's do some math!");
            Console.WriteLine("Please enter a number greater than zero");
            try
            {
                string input = Console.ReadLine();
                int number = int.Parse(input);
                int[] numbers = Populate(new int[number]);
                int sum = GetSum(numbers);
                int product = GetProduct(numbers, sum);
                decimal quotient = GetQuotient(product);

                Console.WriteLine($"Your array size is: {number}");
                Console.WriteLine("The numbers in the array are " + string.Join(",", numbers) + "");
                Console.WriteLine($"The sum of the array is {sum}");
                Console.WriteLine($"{sum} * {product / sum} = {product}");
                Console.WriteLine($"{product} / {product / quotient} = {quotient}");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalid entry. " + e.Message);
            }
            catch (OverflowException)
            {
                Console.WriteLine("The number you entered is too big");
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        /// <summary>
        /// Populate method prompts user to enter numbers to fill int array parameter
        /// </summary>
        /// <param name="arr">An empty int array that is the size the user just inputted</param>
        /// <returns>Popluated int array</returns>
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
        /// <summary>
        /// GetSum method sums up values from the int array parameter
        /// </summary>
        /// <param name="arr">A populated int array</param>
        /// <returns>The int sum of the populated array that is greater than 20</returns>
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
                throw (new Exception($"Value of {sum} is too low"));
            }
        }
        /// <summary>
        /// GetProduct prompts user to choose an index position number of the populated int array and multiplies the index value with the sum of the array
        /// </summary>
        /// <param name="arr">A populated int array</param>
        /// <param name="num">The sum of the populated int array arr</param>
        /// <returns>The int product of the index value and the sum of the array</returns>
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
        /// <summary>
        /// GetQuotient method prompts user to enter divisor and calculates decimal quoitent
        /// </summary>
        /// <param name="num">The int product from GetProdouct</param>
        /// <returns>The decimal quotient of product divded by user inputted divisor</returns>
        static decimal GetQuotient(int num)
        {
            Console.WriteLine($"Please enter a number to divde your product {num} by");
            string input = Console.ReadLine();
            try
            {
                decimal quotient = decimal.Divide(num, Convert.ToInt32(input));
                return quotient;
            }
            catch(DivideByZeroException)
            {
                return 0;
            }
        }
    }
}
