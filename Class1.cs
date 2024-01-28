﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Tortiki
{
    internal class menu
    {
        private int minarrow;
        private int maxarrow;

        public void Perem(int min, int max)
        {
            minarrow = min;
            maxarrow = max;
        }

        public static int Show(int minarrow, int maxarrow)
        {
            int pos = 1;
            ConsoleKeyInfo key;
            do
            {

                Console.SetCursorPosition(0, pos);
                Console.WriteLine("->");

                key = Console.ReadKey();

                Console.SetCursorPosition(0, pos);
                Console.WriteLine("  ");

                if (key.Key == ConsoleKey.UpArrow && pos != minarrow)
                    pos--;
                else if (key.Key == ConsoleKey.DownArrow && pos != maxarrow)
                    pos++;


            } while (key.Key != ConsoleKey.Enter);

            return pos;
        }

    }

}
