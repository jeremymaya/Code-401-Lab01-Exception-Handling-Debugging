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
    }
}
