using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TemperatureCalculator
{
    class TextUtils
    {
        public static void Animate(string text)
        {
            Console.CursorVisible = false;
            Console.WriteLine();

            int delay = 20;

            foreach (var c in text)
            {
                if (Console.KeyAvailable)
                {
                    int left = Console.CursorLeft;
                    int top = Console.CursorTop;

                    if (Console.ReadKey(true).Key != ConsoleKey.Enter)
                    {
                        delay = 1;
                        Console.SetCursorPosition(left, top);
                    }
                }
                Console.Write(c);
                Thread.Sleep(delay);
            }

            Console.WriteLine();
            Console.CursorVisible = true;
        }
    }
}
