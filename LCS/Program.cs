using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Брижак Андрей  ДЗ к курсу Алгоритмы и структуры данных. Задача 2.
//2. * Решить задачу о нахождении длины максимальной последовательности с помощью матрицы.
namespace LCS
{
    class Program
    {
      public static  int MaxArr (int first,  int second)
        {
            if (first> second)
            {
                return first;
            }
            return second; 
        }

        static void Main(string[] args)
        {
            //char[] _GeekBrains = new char[10] { G, E, E, K, B, R, A, I, N, S };
            String s1 = "GEEKBRAINS";
            var _GeekBrains = s1.ToCharArray();

            //char[] _GeekMinds = new char[8];
            String s2 = "GEEKMAINDS";
            var _GeekMinds = s2.ToCharArray();

            int[,] myArr = new int[11, 9];
            
            int max = 0;
            for (int i = 1; i < _GeekBrains.Length-1; i++)
            {
                for (int j = 1; j < _GeekMinds.Length-1; j++)
                {
                    if (_GeekBrains[i] == _GeekMinds[j])
                    {
                        myArr[i, j] = myArr[i - 1, j - 1] +1;
                    }
                    else
                    {
                        myArr[i, j] = MaxArr(myArr[i - 1, j], myArr[i, j - 1]);
                    }
                    Console.Write("{0}\t", myArr[i, j]);
                }
                Console.WriteLine();
                Console.WriteLine("==============================================");
            }

            Console.ReadKey();

            //for (int i = 0; i < length; i++)
            //{

            //}

        }
    }
}
