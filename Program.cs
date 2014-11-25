using System;
using System.Collections.Generic;

namespace ShoppingCartDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput;
            int subtotal = 0;

            // Display items for purchasing
            DisplayPurchaseOptions();
            userInput = GetPurchaseOption();
            subtotal = userInput;

            // Display the summary of the transaction
            double tax = (double) subtotal * (0.095);
            Console.WriteLine("Subtotal: ${0}", subtotal);
            Console.WriteLine("Tax (9.5%): ${0}", tax);
            Console.WriteLine("Total: ${0}", subtotal + tax);

            Console.WriteLine("Press any key to end the program.");
            Console.ReadKey();
        }

        /// <summary>
        /// Display purchase options for user
        /// </summary>
        static void DisplayPurchaseOptions()
        {
            Console.WriteLine("Please choose from the following menu:");
            Console.WriteLine("1. Apple $1.00");
            Console.WriteLine("2. Grapes $2.00");
            Console.WriteLine("3. Mango $3.00");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Which one would you like to purchase?");
        }

        /// <summary>
        /// Get the purchasing option from the user
        /// </summary>
        /// <returns>0 if user didn't give the correct option, more than 0 if user gives an int</returns>
        static int GetPurchaseOption()
        {
            int userInput = 0;
            try
            {
                userInput = Convert.ToInt16(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please enter a whole number!");
            }
            return userInput;
        }
    }
}
