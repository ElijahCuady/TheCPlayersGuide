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
    }
}
