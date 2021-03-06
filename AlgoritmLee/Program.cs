﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Брижак Андрей  ДЗ к курсу Алгоритмы и структуры данных. Задача 1.
//1. Количество маршрутов с препятствиями.Реализовать чтение массива с препятствием и
//нахождение количество маршрутов.
//Например, карта:
//1 1 1
//0 1 0
//0 1 1


namespace AlgoritmLee
{
    class Program
    {

        public const int X = 3;
        public const int Y = 3;

        public static void WaweLee(int x, int y, int len, int[,] myArr)
        {
            LeftWawe(x, y, len, myArr);
            UpWawe(x, y, len, myArr);
            RightWawe(x, y, len, myArr);
            DownWawe(x, y, len, myArr);
        }

        public static void UpWawe(int x, int y, int len, int[,] myArr)
        {
            int upy = y + 1;
            if (upy >= 0 && upy < Y && myArr[x, upy] == 0)
            {
                myArr[x, upy] = len + 1;
                WaweLee(x, upy, len + 1, myArr);
            }
        }

        public static void DownWawe(int x, int y, int len, int[,] myArr)
        {
            int downy = y - 1;
            if (downy >= 0 && downy < Y && myArr[x, downy] == 0)
            {
                myArr[x, downy] = len + 1;
                WaweLee(x, downy, len + 1, myArr);
            }
        }

        public static void RightWawe(int x, int y, int len, int[,] myArr)
        {
            int rightx = x + 1;
            if (rightx >= 0 && rightx < X && myArr[rightx, y] == 0)
            {
                myArr[rightx, y] = len + 1;
                WaweLee(rightx, y, len + 1, myArr);
            }
        }

        public static void LeftWawe(int x, int y, int len, int[,] myArr)
        {
            int leftx = x - 1;
            if (leftx >=0 && leftx < X && myArr[leftx, y] == 0 )
	        {
                myArr[leftx, y] = len + 1;
                WaweLee(leftx, y, len + 1, myArr);
            }
        }

        static void Main(string[] args)
        {
            int[,] myArr = new int[X, Y];
            for (int i = 0; i < X; i++)
            {
                for (int j = 0; j < Y; j++)
                {
                    myArr[i, j] = 0;
                    
                    Console.Write("{0}\t", myArr[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("================");
            Console.ReadKey();

            myArr[0, 1] = -1;
            myArr[0, 2] = -1;
            myArr[2, 1] = -1;

            int x = 0;
            int y = 0;
            int len = 0;

            myArr[0, 0] = -1; //старт
            WaweLee(x, y, len, myArr);
            for (int i = 0; i < X; i++)
            {
                for (int j = 0; j < Y; j++)
                {
                    
                    Console.Write("{0}\t", myArr[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("================");
            Console.ReadKey();
            Console.WriteLine("Count steps to array X=2 Y=2:");
            Console.Write("{0}\t", myArr[2, 2]);
            Console.ReadKey();

        }
    }
}
