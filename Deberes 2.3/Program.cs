using System;

namespace Deberes_2._3
{
    class Program
    {
        static void Main(string[] args)
        {

            uint n = 0;

            do
            {
                Console.WriteLine("Введите количество элементов массива");

                UInt32.TryParse(Console.ReadLine(), out n);

                if (n == 0)
                {
                    Console.WriteLine("Неверная размерность. Размер массива должен быть натуральным числом");
                }
                else
                {

                    int[] ar1 = new int[n];

                    Random rand = new Random();

                    Console.WriteLine("Массив чисел: ");

                    for (int i = 0; i < n; i++)
                    {
                        ar1[i] = rand.Next(-500, 500);

                        Console.Write("{0} ", ar1[i]);
                    }

                    int s = 0;

                    for (int a = 0; a < n - 1; a++)
                    {
                        for (int b = a + 1; b < n; b++)
                        {
                            if (ar1[a] > ar1[b])
                            {
                                s = ar1[b];
                                ar1[b] = ar1[a];
                                ar1[a] = s;
                            }
                        }
                    }
                    Console.WriteLine(" ");

                    Console.WriteLine("Отсортированный массив: ");

                    for (int i = 0; i < n; i++)
                    {
                        Console.Write("{0} ", ar1[i]);
                    }

                    Console.Read();
                }
            }
            while (n == 0);
        }
    }
}
