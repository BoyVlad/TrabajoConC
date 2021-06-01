using System;

namespace Deberes_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст для проверки: ");
            string str = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Задайте текст, который вы желаете заменить: ");
            string cambiar = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Задайте текст, на который вы желаете заменить: ");
            string corregir = Console.ReadLine();

            try
            {
                int buscar = str.IndexOf(cambiar);
                //Console.WriteLine("Позиция замены: " +buscar);
                string nueva = str.Remove(buscar, cambiar.Length);
                //Console.WriteLine("Послее вырезания");
                Console.WriteLine();
                //Console.WriteLine(nueva);
                //Console.WriteLine("После вставки");
                string nueva1 = nueva.Insert(buscar, corregir);

                Console.WriteLine();

                Console.WriteLine(nueva1);
            }
            catch
            {
                Console.WriteLine("Не получилось найти тест ({0}) в тексте {1}", cambiar, str);
            }
            Console.ReadLine();
        }
    }
}