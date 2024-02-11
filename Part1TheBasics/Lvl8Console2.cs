using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCPlayersGuide.Part1TheBasics
{
    internal class Lvl8Console2
    {
        public static void ReadKeyAndColor()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("This is no input ReadKey() ");
            Console.ReadKey();

            Console.Write("\nThis is ReadKey with boolean ");
            Console.ReadKey(true);

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Magenta;
        }
        public static void ClearTest()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("Console cleared.");
        }

        public static void BeepTest()
        {
            Console.Beep(440, 5000);
        }

        public static void SweetMusic()
        {
            Console.WriteLine("Hi!");
            int frequency = 400;
            int duration = 1000;

            for (int i = 0; i < 10; i++)
            {
                Console.Beep(frequency, duration);
                frequency += 100;
            }
        }
        public static void InduceEpilepsy()
        {
            for (int i = 0; i < 10; i++)
            {

                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear(); // Apply the changes immediately to the entire screen
                Thread.Sleep(100);

                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear(); // Apply the changes immediately to the entire screen
                Thread.Sleep(100);
            }

        }

        public static void InterpolationAndVerbatim()
        {
            Console.WriteLine($"What every{1}happened\nwith \\ \n");
        }
        public static void AlignmentTest()
        {
            Console.WriteLine("Alignment...");
            string name1 = Console.ReadLine();
            string name2 = Console.ReadLine();

            Console.WriteLine("   *****#####&&&&&%%%%%@@@@@£££££");
            Console.WriteLine($"#1:{name1,10}");
            Console.WriteLine($"#2:{name2,30}");
            Console.WriteLine($"#1:{name2,10}");

            Console.WriteLine($"{name1,-20} - 1");
            Console.WriteLine($"{name2,-20} - 2");

            /*
               *****#####&&&&&%%%%%@@@@@£££££
            #1:     manny
            #2:         bruce wayne is batman
            #1:bruce wayne is batman
            manny                - 1
            bruce wayne is batman - 2
             */
        }
        public static void FormattingTest()
        {
            float num = 123.456789F;

            Console.WriteLine($"{num:0.00}");
            Console.WriteLine($"{num:0000.00}");
            Console.WriteLine();

            float num2 = 42;
            float num3 = 42.12F;
            Console.WriteLine($"{num2:#.##}");
            Console.WriteLine($"{num3:###.##}");
            Console.WriteLine($"{num3:0##.##}");
            Console.WriteLine($"{num3:0##.000}");

            Console.WriteLine($"{num:F}");
            Console.WriteLine($"{num:F6}");
            Console.WriteLine($"{num:P}");

        }
        public static void TheDefenseofConsolas()
        {
            //• Change the window title to be “Defense of Consolas”.
            Console.Title = "Defense of Consolas";
            Console.WriteLine("Let's defend the city!");

            //• Ask the user for the target row and column.
            int[] targets;
            while (true)
            {
                targets = getTargets();
                if (targets.Length != 0)
                {
                    break;
                }
                Console.WriteLine("Try again!\n");
            }

            //• Compute the neighboring rows and columns of where to deploy the squad.
            int lowerRow = targets[0] - 1;
            int upperRow = targets[0] + 1;

            int leftCol = targets[1] - 1;
            int rightCol = targets[1] + 1;

            //• Display the deployment instructions in a different color of your choosing.
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine("Deploy to:");
            Console.WriteLine($"({targets[0]}, {leftCol})");
            Console.WriteLine($"({lowerRow}, {targets[1]})");
            Console.WriteLine($"({targets[0]}, {rightCol})");
            Console.WriteLine($"({upperRow}, {targets[1]})");

            //• Play a sound with Console.Beep when the results have been computed and displayed.
            Console.WriteLine("City defended!");
            Console.Beep(440, 2500);
        }

        public static int[] getTargets()
        {
            Console.Write("Target row? ");
            string targetRow = Console.ReadLine();

            Console.Write("Target column? ");
            string targetCol = Console.ReadLine();

            try
            {
                int row = Convert.ToInt32(targetRow);
                int column = Convert.ToInt32(targetCol);

                // Out of bounds
                if (row < 1 || column < 1 || row > 8 || column > 8)
                {
                    return Array.Empty<int>();
                }

                return new int[] { row, column };
            }
            catch (Exception ex)
            {
                return Array.Empty<int>();
            }
        }
    }
}
