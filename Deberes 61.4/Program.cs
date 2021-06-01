using System;

namespace Deberes_1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int largo = rand.Next(21, 41);

            Console.WriteLine(largo);

            int columna = largo / 5;

            Console.WriteLine(columna);

            int plus = (largo - columna * 2) / 3;

            Console.WriteLine(plus);

            for (int i = 0; i < largo; i++)
            {
                if (i == 0 || i == largo - 1)
                {
                    Console.WriteLine(new string('.', largo));
                }
                else if (i > 0 && i < columna || i >= columna * 3 + plus && i < largo - 1)
                {
                    Console.WriteLine("{0}{1}{2}",
                    new string('.', 1),
                    new string(' ', largo - 2),
                    new string('.', 1));
                }
                else if ((i >= columna && i < columna * 2) ||
                    (i >= columna * 2 + plus && i < columna * 3 + plus))
                {
                    Console.WriteLine("{0}{1}{2}{3}{4}",
                        new string('.', 1),
                        new string(' ', columna * 2 - 1),
                        new string('*', plus),
                        new string(' ', largo - columna * 2 - plus - 1),
                        new string('.', 1));
                }

                else
                {
                    Console.WriteLine("{0}{1}{2}{3}{4}",
                        new string('.', 1),
                        new string(' ', columna - 1),
                        new string('*', columna * 2 + plus),
                        new string(' ', largo - columna * 3 - plus - 1),
                        new string('.', 1));
                }
            }
            Console.ReadLine();
        }
    }
}
