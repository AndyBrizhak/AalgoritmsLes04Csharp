using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Брижак Андрей  ДЗ к курсу Алгоритмы и структуры данных. Задача 3.
//Требуется обойти конём шахматную доску размером NxM, пройдя через все поля доски по
//одному разу.
namespace Knight
{
    class Program
    {
        static int[,] Ar = new int[8, 8];
        static int X, Y, n;

        static void Main(string[] args)
        {
            int[,] Ar = new int[8, 8];
            Console.Write("Введите X (1-8): ");
            X = Int32.Parse(Console.ReadLine()) - 1;
            Console.Write("Введите Y (1-8): ");
            Y = Int32.Parse(Console.ReadLine()) - 1;
            Move(X, Y);
            Console.ReadLine();
            //for (int i = 0; i < 8-1; i++)
            //{
            //    for (int j = 0; j < 8 - 1; j++)
            //    {
            //        Console.Write("{0}\t", Ar[i, j]);
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();
        }

        static void Move(int X, int Y)
        {
            int iX = 0, iY = 0, nn = ++n;
            bool WasStep = false;
            Ar[X, Y] = 1;
            for (int i = 0; i < 8; i++)
            {
                switch (i)
                {
                    case 0: iX = X + 1; iY = Y - 2; break;
                    case 1: iX = X + 2; iY = Y + 1; break;
                    case 2: iX = X - 1; iY = Y + 2; break;
                    case 3: iX = X - 2; iY = Y - 1; break;
                    case 4: iX = X - 1; iY = Y - 2; break;
                    case 5: iX = X + 2; iY = Y - 1; break;
                    case 6: iX = X + 1; iY = Y + 2; break;
                    case 7: iX = X - 2; iY = Y + 1; break;
                }
                if (iX > -1 && iX < 8 && iY > -1 && iY < 8 && Ar[iX, iY] == 0)
                {
                    WasStep = true;
                    Console.WriteLine("{0,4}:  {1}-{2}  ->   {3}-{4}", "(" + nn + ")", X + 1, Y + 1, iX + 1, iY + 1);
                    Move(iX, iY);
                }
            }
            if (!WasStep) n--;
        }
    }
}
