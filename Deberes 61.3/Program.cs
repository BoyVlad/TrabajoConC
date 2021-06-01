using System;
using System.Globalization;

namespace Deberes_1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите дату ввашего рождения в формате ДД.ММ.ГГГГ");

            string con = Console.ReadLine();

            DateTime Naci = new DateTime();

            DateTime Ahora = DateTime.Today;

            try
            {
                Naci = DateTime.Parse(con);

                TimeSpan dif = Ahora - Naci;

                int Day = dif.Days;

                System.Console.WriteLine("Раздница в днях: {0} ", Day);

                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Введенны данные в неверном формате");

                Console.ReadLine();
            }
        }
    }
}
