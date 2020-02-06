//
// Author: Ettienne Voges
// Program, for week 4: Using a Method
//
//
using System;
using System.Text.RegularExpressions;


namespace Deliverable3Method
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call a method to request and print a user name
            HandleUserName();

            // Exit with 0 success exit code
            Environment.Exit(0);
        }

        /**
         * Handle user name input and output
         */
        static private void HandleUserName()
        {
            // Ask the user his/her name
            Console.WriteLine("Please enter your name?");

            // Declare a name variable
            String name;

            // Read the user name from standard input
            name = Console.ReadLine();

            // Define a regular expression for any numeric characters
            Regex regExp = new Regex(@".*[^A-Za-z\s]+.*", RegexOptions.Compiled);

            // Use the regular expression to check for a match
            if (regExp.IsMatch(name))
            {
                // Print a message with the result string
                Console.WriteLine("Your input contains unexpected name characters, please try again");
                return;
            }

            // Print a message with the result string
            Console.WriteLine("Hello " + name);

        }
    }
}
