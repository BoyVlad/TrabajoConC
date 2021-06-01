using System;

namespace Deberes_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            UInt32 N = 0;
            UInt32 M = 0;
            int s = 0;
            do
            {
                Console.WriteLine("Введите количество столбцов массива: ");

                UInt32.TryParse(Console.ReadLine(), out N);

                if (N == 0)
                {
                    Console.WriteLine("Размер массива должен быть натуральным числом");
                }
            }
            while (N == 0);

            do
            {
                Console.WriteLine("Введите строк массива: ");

                UInt32.TryParse(Console.ReadLine(), out M);

                if (M == 0)
                {
                    Console.WriteLine("Размер массива должен быть натуральным числом");
                }
            }
            while (M == 0);
            int[] SummArray = new int[N];

            int[,] array1 = new int[M, N];

            Random rand = new Random();

            for (int i = 0; i < M; i++) //заполняем массив рандомными числами -500..500
            {
                for (int j = 0; j < N; j++)
                {
                    array1[i, j] = rand.Next(-500, 500);

                    Console.Write("{0} ", array1[i, j]);
                }
                Console.WriteLine();
            }


            for (int j = 0; j < N; j++) //массив суммы столбца
            {

                for (int i = 0; i < M; i++)

                {
                    SummArray[j] = SummArray[j] + array1[i, j];
                }
            }
            Console.WriteLine("Summ Array:");

            for (int j = 0; j < N; j++)
            {
                Console.Write("{0} ", SummArray[j]);
            }
            Console.WriteLine();

            Console.WriteLine("Сортируем по сумме столбца");

            for (int j = 0; j < N - 1; j++)
            {
                for (int k = j + 1; k < N; k++)
                {
                    if (SummArray[j] > SummArray[k])
                    {

                        s = SummArray[j];
                        SummArray[j] = SummArray[k];
                        SummArray[k] = s;

                        for (int i = 0; i < M; i++)
                        {
                            s = array1[i, j];
                            array1[i, j] = array1[i, k];
                            array1[i, k] = s;
                        }
                    }
                }

            }

            Console.WriteLine();

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write("{0} ", array1[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Summ Array:");
            for (int j = 0; j < N; j++)
            {
                Console.Write("{0} ", SummArray[j]);
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}

