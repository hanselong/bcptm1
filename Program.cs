using System;
using System.Collections.Generic;

namespace ShoppingCartDemo
{
    class Program
    {
        private static const double TAX = 0.095;

        static void Main(string[] args)
        {
            int userInput = 0;
            int[] purchases = new int[4]; // apples, grapes, mangos, soda
            double[] costs = new double[] { 1, 2, 3, 0.5 };

            DisplayMainOptions();
            userInput = GetPurchaseOption();
            while (userInput != 4)
            {
                if (userInput == 1)
                {
                    doPurchases(purchases);
                }
                else if (userInput == 2)
                {
                    removePurchases(purchases);
                }
                else if (userInput == 3)
                {
                    viewShoppingCart(purchases);
                }
                else
                {
                    Console.WriteLine("You didn't enter a number between 1 and 4, try again.");
                }
            }

            // Display items for purchasing
            //DisplayPurchaseOptions();
            //userInput = GetPurchaseOption();

            double subtotal = 0;
            for (int i = 0; i < purchases.Length; ++i)
            {
                subtotal += purchases[i] * costs[i];
            }

            double tax = subtotal * TAX;
            Console.WriteLine("Subtotal: ${0:f2}", subtotal);
            Console.WriteLine("Tax (9.5%): ${0:f2}", tax);
            Console.WriteLine("Total: ${0:f2}", subtotal + tax);

            Console.WriteLine("Press any key to end the program.");
            Console.ReadKey();
        }

        private static void removePurchases(int[] purchases)
        {
            throw new NotImplementedException();
        }

        private static void viewShoppingCart(int[] purchases)
        {
            String[] items = new String[] { "Apples", "Grapes", "Mangos", "Soda" };
            for (int i = 0; i < purchases.Length; ++i)
            {
                if (purchases[i] > 0)
                {
                    Console.WriteLine("You have purchased " + purchases[i] + " of item " + items[i]);
                }
            }
            if (purchases[0] == 0 && purchases[1] == 0 && purchases[2] == 0 && purchases[3] == 0)
            {
                Console.WriteLine("You haven't bought anything!");
            }

        }

        private static void doPurchases(int[] purchases)
        {

            DisplayPurchaseOptions();
            int userInput = GetPurchaseOption();
                
                

            while (userInput != 5)
            {
                if (userInput < 1 || userInput > 5)
                {
                    Console.WriteLine("Please enter a number from 1 to 5.");
                    DisplayPurchaseOptions();
                    userInput = GetPurchaseOption();
                    continue;
                }
                viewShoppingCart(purchases);
                ++purchases[userInput - 1];
                // Display the summary of the transaction
                DisplayPurchaseOptions();
                userInput = GetPurchaseOption();
            }
        }

        private static void DisplayMainOptions()
        {
            Console.WriteLine("Please choose one of these options");
            Console.WriteLine("1. Do purchases");
            Console.WriteLine("2. Remove purchases");
            Console.WriteLine("3. View Shopping Cart");
            Console.WriteLine("4. Check out");
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
            Console.WriteLine("4. Soda $0.50");
            Console.WriteLine("5. Stop purchasing");
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
