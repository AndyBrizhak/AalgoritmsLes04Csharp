using System;
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
        static void Main(string[] args)
        {
            int[,] myArr = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    myArr[i, j] = 0;
                    Console.Write("{0}\t", myArr[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();

            myArr[0, 1] = -1;
            myArr[0, 2] = -1;
            myArr[2, 1] = -1;

        }
    }
}
