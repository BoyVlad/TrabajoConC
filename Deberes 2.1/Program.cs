using System;

namespace Deberes_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Polimondron = false;

            Console.WriteLine("Введите любой текст для проверки на палиндромом: ");

            string entra = Console.ReadLine();

            string str = entra.ToLower().Replace(" ", string.Empty);

            for (int i = 0; i < str.Length; i++)

            {
                if (str[i] != str[str.Length - i - 1])
                {
                    Polimondron = false;
                    break;
                }
                else
                {
                    Polimondron = true;
                }
            }
            if (Polimondron)
            {
                Console.WriteLine("{0} являеться полиндром", entra);
            }
            else
            {
                Console.WriteLine("{0} - не полиндром", entra);
            }
            Console.ReadLine();
        }
    }
}
