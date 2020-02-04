using System;
using System.Collections.Generic;

namespace Lab3._2_Shopping_List2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> inventory = new Dictionary<string, double>();
            inventory["apple"] = 0.99;
            inventory["banana"] = 0.59;
            inventory["cauliflower"] = 1.59;
            inventory["dragonfruit"] = 2.19;
            inventory["elderberry"] = 1.79;
            inventory["figs"] = 2.09;
            inventory["grapefruit"] = 1.99;
            inventory["honeydew"] = 3.49;

            List<string> itemsOrdered = new List<string>();
            List<double> price = new List<double>();
            double sum = 0;
            bool addItem = true;

            Console.WriteLine("Welcome to my grocery store");
            while (addItem)
            {
                Console.WriteLine("Item\t\tPrice");
                Console.WriteLine("=======================");

                //added a foreach loop to print each iteam and create the menu
                foreach (KeyValuePair<string, double> item in inventory)
                {
                    Console.WriteLine($"{item.Key,-15} ${item.Value}");

                }

                while (addItem)
                {
                    Console.Write("What item would you like to order?: ");
                    string customerInput = Console.ReadLine();
                    while (!inventory.ContainsKey(customerInput)) 
                    {
                        Console.WriteLine("\nSorry, we don't have those. Please try again.");
                        
                        Console.WriteLine("Item\t\tPrice");
                        Console.WriteLine("=======================");

                        //added a foreach loop to print each iteam and create the menu
                        foreach (KeyValuePair<string, double> item in inventory)
                        {
                            Console.WriteLine($"{item.Key,-15} ${item.Value}");

                        }
                        Console.Write("What item would you like to order?: ");
                        
                        customerInput = Console.ReadLine();
                    }

                    itemsOrdered.Add(customerInput); //adding items to items ordered list. .
                    price.Add(inventory[customerInput]); //adding items to price list using dictionary key.
                    sum += inventory[customerInput]; // is adding the value from the inventory dictionary.

                    Console.WriteLine($"Adding {customerInput} to to cart at ${inventory[customerInput]}");
                    Console.Write("Would you like to add another item to your order? (y/n): ");
                    string addAnotherItem = Console.ReadLine();

                    if (addAnotherItem == "n")
                    {
                        addItem = false;
                    }
                    Console.WriteLine("\nItem\t\tPrice");
                    Console.WriteLine("=======================");

                    //added a foreach loop to print each iteam and create the menu
                    foreach (KeyValuePair<string, double> item in inventory)
                    {
                        Console.WriteLine($"{item.Key,-15} ${item.Value}");

                    }

                }

                Console.WriteLine("Thanks for your order!\n\nHers's what you got:");
                for (int i = 0; i < itemsOrdered.Count; i++)
                {
                    Console.WriteLine($"{itemsOrdered[i]}\t\t${price[i]}");
                }
                Console.WriteLine($"Average price per item in order was ${Math.Round((sum / itemsOrdered.Count), 2)}");
            }
            

        }


    }
}
