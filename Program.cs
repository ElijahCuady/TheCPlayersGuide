using System;
using System.Runtime.InteropServices;
using TheCPlayersGuide.Part1TheBasics;

namespace TheCPlayersGuide
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BeepTest();
        }
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
            for (int i  = 0; i < 10; i++)
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
       
    }
}
