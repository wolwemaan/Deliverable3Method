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
            Regex regExp = new Regex(@".*\d.*",
                RegexOptions.Compiled | RegexOptions.IgnoreCase);
            if (regExp.IsMatch(name))
            {
                // Print a message with the result string
                Console.WriteLine("Your input countain a numeric which is unexpected in a name, please try again");
                return;
            }

            // Print a message with the result string
            Console.WriteLine("Welcome " + name);

        }
    }
}
