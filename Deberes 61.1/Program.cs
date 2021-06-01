using System;

namespace Deberes_1._2
{
    class Program
    {
        static void Main(string[] args)
        {

            int it = 10, paired = 0, unpaired = 0, res = 0, save = 100;

            try
            {
                Console.Write("Ввести число в диапазоне от 100 до 100000000>>>>");

                string User = Console.ReadLine();

                int number = int.Parse(User);

                if (number <= 100000000)
                {
                    if (number >= 100)
                    {
                        do
                        {

                            res = number % it;
                            Console.WriteLine("Проверка {0}", res);
                            if (res % 2 == 0)
                            {
                                paired++;
                                Console.WriteLine(" - четное");
                            }
                            else
                            {
                                unpaired++;
                                Console.WriteLine(" - нечетное");
                            }

                            save = number / it;

                            number = save;

                        }
                        while (save >= 1);

                        int summ = paired + unpaired;

                        Console.WriteLine("В числе {0}% четных и {1}% нечетных цифр", paired * 100 / summ, unpaired * 100 / summ);
                    }
                    else
                        Console.WriteLine("Введенное число меньше 100");
                }
                else
                    Console.WriteLine("Введенное число больше 100000000");
            }
            catch
            {
                Console.WriteLine("Введенный текст не являеться целым числом из диапазона");
            }
            Console.ReadLine();
        }
    }
}
