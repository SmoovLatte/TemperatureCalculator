using System;
using System.Collections.Generic;
using System.Threading;
//using System.Runtime.InteropServices.ComTypes;

namespace TemperatureCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool gameOn = true;

            while (gameOn)
            {
                //Console.Clear();
                giveSelection();


                ConsoleKeyInfo input = Console.ReadKey();
                Console.WriteLine();

                switch (input.Key)
                {
                    case ConsoleKey.D1:
                        // calling the method Convert Fahrenheit to Celcius
                        Console.WriteLine();
                        fahrenheitToCelcius();
                        Thread.Sleep(800);
                        break;

                    case ConsoleKey.D2:
                        // calling the celcius to fahrenheit method
                        Console.WriteLine();
                        celsiusToFahrenheit();
                        Thread.Sleep(800);
                        break;

                    case ConsoleKey.D0:
                        gameOn = false;
                        break;

                    default:
                        Console.WriteLine(); Console.WriteLine();
                        TextUtils.Animate("Invalid option. Please, choose between 0 - 2.");
                        Console.WriteLine(); Console.WriteLine();
                        break;

                }
            }
            goodBye();
        }

        private static void goodBye()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("You have chosen to exit the program."); Console.WriteLine();
            TextUtils.Animate("Press any key to close the console");
        }

        private static void celsiusToFahrenheit()
        {
            //F = 9 / 5 * C + 32
            double convertedValue = 0;
            string textOut = string.Empty;

            for (int i = 0; i <= 100; i += 5)
            {
                convertedValue = (9.0/5.0) * i + 32;
                textOut = string.Format ( "{0,16:f2} C = {1,6:f2} F", i, convertedValue);
                Console.WriteLine(textOut);
            }
            
        }

        private static void fahrenheitToCelcius()
        {
            double convertedValue = 0;
            string textOut = string.Empty;

            for (int i = 0; i <= 100; i += 4)
            {
                convertedValue = (5.0/9.0) * (i - 32);
                textOut = string.Format("{0,16:f2} F = {1,6:f2} C", i, convertedValue);
                Console.WriteLine(textOut);
            }

            
                //Console.WriteLine($"             {fahrenheit} F = {celsius} C              ");
        }

        internal static void giveSelection()
        {
            Console.WriteLine("*************************************");
            //27 x *
            Console.WriteLine("             MAIN MENU              ");
            Console.WriteLine("*************************************");
            Console.WriteLine("  Convert Fahrenheit to Celcius : 1 ");
            Console.WriteLine("  Convert Celcius to Fahrenheit : 2 ");
            Console.WriteLine("  Exit the Converter            : 0 ");
            Console.WriteLine("************************************");
            Console.WriteLine();
            Console.Write("Your Choice: ");
        }
    }
}
