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
            RepairingTheClockTower();
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
    }
}
