﻿using System;

namespace Laba11
{
    class Program
    {
        static void Main(string[] args)
        {
            const int SIZE = 5;
            string[] buf = new string[SIZE] {"люблю",
                      "когда",
                      "тепло",
                      "рядом",
                      "дома!"};
            int[,] grid = new int[SIZE, SIZE]{{0, 0, 1, 0, 1},
                          {1, 1, 0, 1, 0},
                          {0, 0, 0, 0, 0},
                          {0, 0, 0, 1, 0},
                          {0, 0, 0, 0, 0}};
            // вывод зашифрованного сообщения
            for (int i = 0; i < SIZE; i++)
            {
                Console.WriteLine(buf[i]);
            }
            Console.WriteLine("");

            // прямой обход решетки
            Console.WriteLine("0:");
            for (int i = 0; i < SIZE; i++)
                for (int j = 0; j < SIZE; j++)
                    if (grid[i, j] == 1)
                    {
                        Console.Write(buf[i][j]);
                    }
            Console.WriteLine("");
            // поворот решетки на 90 градусов по часовой стрелке
            Console.WriteLine("90:");
            for (int i = 0; i < SIZE; i++)
                for (int j = 0; j < SIZE; j++)
                    if (grid[SIZE - j - 1, i] == 1)
                    {
                        Console.Write(buf[i][j]);
                    }
            Console.WriteLine("");
            // поворот решетки на 180 градусов по часовой стрелке
            Console.WriteLine("180:");
            for (int i = 0; i < SIZE; i++)
                for (int j = 0; j < SIZE; j++)
                    if (grid[SIZE - i - 1, SIZE - j - 1] == 1)
                    {
                        Console.Write(buf[i][j]);
                    }
            Console.WriteLine("");
            // поворот решетки на 270 градусов по часовой стрелке
            Console.WriteLine("270:");
            for (int i = 0; i < SIZE; i++)
                for (int j = 0; j < SIZE; j++)
                    if (grid[j, SIZE - i - 1] == 1)
                    {
                        Console.Write(buf[i][j]);
                    }
            Console.WriteLine("");

            Console.ReadLine();
        }
    }
}
