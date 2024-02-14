using Microsoft.VisualBasic;
using System;
using System.Data.Common;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Threading.Channels;
using System.Threading.Tasks;
using TheCPlayersGuide.Part1TheBasics;

namespace TheCPlayersGuide
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BuyingInventory();

        }

        public static void switchTesting1()
        {
            int choice = Convert.ToInt32(Console.ReadLine());

            string response;
            response = choice switch
            {
                1 => "Ye rest and recover your health.",
                2 => "Raiding the port town get ye 50 gold doubloons.",
                3 => "The wind is at your back; the open horizon ahead.",
                4 => "'Tis but a baby Kraken, but still eats toy boats.",
                _ => "Apologies. I do not know that one."
            };
            Console.WriteLine(response);
        }

        public static void switchTesting2()
        {
            int choice = Convert.ToInt32(Console.ReadLine());

            // var response; // <- doesn't work, needs to be same
            string response;
            response = choice switch
            {
                1 => "Ye rest and recover your health.",
                2 => "Raiding the port town get ye 50 gold doubloons.",
                3 => "The wind is at your back; the open horizon ahead.",
                4 => "'Tis but a baby Kraken, but still eats toy boats.",
                //5 => Console.WriteLine("You clicked #5!"),  // <- doesn't work, needs to be same
                // 6 => 120, // <- doesn't work, needs to be same
                _ => "Apologies. I do not know that one."
            };
            Console.WriteLine(response);
        }

        public static void BuyingInventory()
        {
            //• Build a program that will show the menu illustrated above.
            // TO:DO create an object/ key-pair so you can show both item name and item cost
            string menu = "The following items are available:" +
                "\n1 – Rope" +
                "\n2 – Torches" +
                "\n3 – Climbing Equipment" +
                "\n4 – Clean Water" +
                "\n5 – Machete" +
                "\n6 – Canoe" +
                "\n7 – Food Supplies" +
                "\nWhat number do you want to see the price of? 2" +
                "\nTorches cost 15 gold.\n";
            Console.WriteLine(menu);

            //• Ask the user to enter a number from the menu.
            Console.Write("Enter the number here: ");
            int menuItem = Convert.ToInt32(Console.ReadLine());
            bool menuItemExists = (menuItem >= 1) && (menuItem <= 7);

            if (!menuItemExists)
            {
                Console.WriteLine("Can’t sell if you something I don't have or know of :(");
            }
            else
            {
                //• Using the information above, use a switch (either type) to show the item’s cost.
                int gold;
                gold = menuItem switch
                {
                    1 => 10,
                    2 => 15,
                    3 => 25,
                    4 => 1,
                    5 => 20,
                    6 => 200,
                    7 => 1,
                    _ => 0
                };

                Console.WriteLine($"Menu item #{menuItem} costs {gold} gold!");
            }


        }
    }
}
