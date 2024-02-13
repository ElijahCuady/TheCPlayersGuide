using System;
using System.Data.Common;
using System.Drawing;
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
            Watchtower();

        }

        public static void RepairingTheClockTower()
        {
            int inputNum = Convert.ToInt32(Console.ReadLine());

            if(inputNum % 2 != 0) 
            {
                Console.WriteLine("Tock"); // Odd
            }
            else
            {
                Console.WriteLine("Tick"); // Even
            }
        }

        public static void Watchtower()
        {
            Console.Write("What's the enemy's X coordinate? ");
            string xInput = Console.ReadLine();


            Console.Write("What's the enemy's Y coordinate? ");
            string yInput = Console.ReadLine();

            try
            {
                float x = Convert.ToSingle(xInput);
                float y = Convert.ToSingle(yInput);
                
                // evaluate x, then y for every given x
                if (x < 0) xLessThanZero(y);
                else if (x == 0) xEqualsThanZero(y);
                else if (x > 0) xGreaterThanZero(y);



            }
            catch (Exception ex)
            {
                Console.WriteLine("Coordinates unclear... You're on your own!");
            }
        }

        public static void xLessThanZero(float y)
        {
            if(y > 0) Console.WriteLine("The enemy is NorthWest!");
            else if (y == 0) Console.WriteLine("The enemy is West!!");
            else if (y < 0) Console.WriteLine("The enemy is SouthWest!");

        }

        public static void xEqualsThanZero(float y)
        {
            if (y > 0) Console.WriteLine("The enemy is North!!");
            else if (y == 0) Console.WriteLine("The enemy is here!!!");
            else if (y < 0) Console.WriteLine("The enemy is South!!");

        }

        public static void xGreaterThanZero(float y)
        {
            if (y > 0) Console.WriteLine("The enemy is NorthEast!");
            else if (y == 0) Console.WriteLine("The enemy is East!");
            else if (y < 0) Console.WriteLine("The enemy is SouthEast!");

        }
    }
}
