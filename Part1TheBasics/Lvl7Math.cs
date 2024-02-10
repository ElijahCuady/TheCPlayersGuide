using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TheCPlayersGuide.Part1TheBasics
{
    internal class Lvl7Math
    {
        public static void divisionByZero()
        {
            try
            {
                int a = 3;
                int b = 0;
                int result = a / b;
                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                Console.WriteLine("Couldn't divide by zero");
            }

            double c = 0;
            double d = 0;

            var result2 = c / d;
            Console.WriteLine(result2.GetType());
            Console.WriteLine(result2);
        }
        public static void TheTriangleFarmer()
        {
            var userName = "Elijah";
            Console.WriteLine($@"C:\Users\{userName}\Documents\Areas.txt");

            Console.WriteLine("Let's calculate the are of a triangle!");
            Console.Write("Type in the base size: ");
            string inputBaseSize = Console.ReadLine();

            Console.Write("Type in the height: ");
            string inputHeight = Console.ReadLine();

            try
            {
                float baseSize = Convert.ToSingle(inputBaseSize);
                float height = Convert.ToSingle(inputHeight);

                float area = (baseSize * height) / 2;

                Console.WriteLine($"The area = {area}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Couldn't convert the user's input or unable to calculate the area: {0}", ex);
            }
        }

        public static void TheFourSistersAndTheDuckbear()
        {
            Console.Write("How many eggs were gathered? ");
            string eggsGathered = Console.ReadLine();
            try
            {
                int countEggs = Convert.ToInt32(eggsGathered);

                if (countEggs < 0)
                {
                    Console.WriteLine("How do you have negative eggs? Perhaps you lost some?");
                }
                else
                {
                    Console.WriteLine($"Each sister will get {countEggs / 4} egg(s).");
                    Console.WriteLine($"The duckbear will get {countEggs % 4} egg(s).");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Please insert a valid number of eggs :D");
            }
        }

        public static void TheDominionOfKings()
        {

            Console.Write("How many provinces do you have? ");
            string inputProvinces = Console.ReadLine();

            Console.Write("How many duchies do you have? ");
            string inputDuchies = Console.ReadLine();

            Console.Write("How many estates do you have? ");
            string inputEstates = Console.ReadLine();


            try
            {
                int countProvinces = Convert.ToInt32(inputProvinces);
                int countDuchies = Convert.ToInt32(inputDuchies);
                int countEstates = Convert.ToInt32(inputEstates);

                int totalScore = countEstates + (countDuchies *= 3) + (countProvinces *= 6);
                Console.WriteLine($"The user has {totalScore} points!");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Couldn't convert");
            }
        }

        public static void incrementAndDecrement()
        {
            int x;
            x = 5;
            int y = ++x;
            Console.WriteLine(y); // 6

            x = 5;
            int z = x++;
            Console.WriteLine(z); // 5
            Console.WriteLine(x); // 6 
        }

        public static void testingClamp()
        {
            Console.WriteLine("Write a number");

            float num = Convert.ToSingle(Console.ReadLine());

            int startRange = 0;
            int endRange = 100;

            if (num == 0)
            {
                Console.WriteLine("You wrote 0!");
            }
            else if (num == 100)
            {
                Console.WriteLine("You wrote 100!");
            }
            else
            {
                var result = Math.Clamp(num, startRange, endRange);
                Console.WriteLine(result);
            }
        }
    }
}
