using System;


namespace Deberes_1._2
{
    class Program
    {
        static void Main(string[] args)
        {

            int number, lN = 0, rN = 0, b;

            Console.WriteLine("Введите номер  билета(6-значное число)>>>>>");

            string Num = Console.ReadLine();

            int v = Num.Length;

            if (v == 6)
            {
                try
                {
                    number = int.Parse(Num);

                    number = number + 1000000;

                    for (int i = 0; i <= 2; i++)
                    {
                        b = number % 10;
                        //Console.WriteLine("b rN = " + b);
                        number = number / 10;
                        //Console.WriteLine("number r = " + number);
                        rN = rN + b;
                        //Console.WriteLine("rN = " + rN);
                    }
                    for (int i = 0; i <= 2; i++)
                    {
                        b = number % 10;
                        //Console.WriteLine("b lN = " + b);
                        number = number / 10;
                        //Console.WriteLine("number l = " + number);
                        lN = lN + b;
                        //Console.WriteLine("lN = " + lN);
                    }
                    //Console.WriteLine("lN =" + lN);
                    //Console.WriteLine("rN= " + rN);
                    if (lN == rN)
                    {
                        Console.WriteLine("Этот билет счасливый!");
                    }
                    else
                    {
                        Console.WriteLine("К сожелению, этот билет не счасливый...");
                    }
                }
                catch
                {
                    Console.WriteLine("Введенный текст не 6-значное число (000000)");
                }
            }
            else
            {
                Console.WriteLine("Введенный текст не 6-значное число (000000)");
            }
            Console.Read();
        }
    }
}

